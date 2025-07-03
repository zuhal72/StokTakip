using Microsoft.AspNetCore.Mvc;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.WebUI.Controllers
{
    public class TedarikciController : Controller
    {
        private readonly IUnitOfWorkService _unitOfWork;

        public TedarikciController(IUnitOfWorkService unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Tedarikçileri listele
        public async Task<IActionResult> Index()
        {
            var tedarikciler = await _unitOfWork.TedarikciService.GetAllAsync();
            return View(tedarikciler);
        }

        // Tedarikçi detay sayfası
        public async Task<IActionResult> Detay(int id)
        {
            var tedarikci = await _unitOfWork.TedarikciService.GetByIdAsync(id);
            if (tedarikci == null)
                return NotFound();

            return View(tedarikci);
        }

        // E-posta ile tedarikçi arama sayfası (GET)
        public IActionResult Ara()
        {
            return View();
        }

        // E-posta ile tedarikçi arama işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ara(string eposta)
        {
            if (string.IsNullOrEmpty(eposta))
            {
                ModelState.AddModelError("", "E-posta adresi boş olamaz.");
                return View();
            }

            var tedarikci = await _unitOfWork.TedarikciService.GetByEpostaAsync(eposta);
            if (tedarikci == null)
            {
                ModelState.AddModelError("", "Bu e-postaya sahip tedarikçi bulunamadı.");
                return View();
            }

            return RedirectToAction(nameof(Detay), new { id = tedarikci.Id });
        }

        // Yeni tedarikçi ekleme sayfası (GET)
        public IActionResult Ekle()
        {
            return View();
        }

        // Yeni tedarikçi ekleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Tedarikci tedarikci)
        {
            if (!ModelState.IsValid)
                return View(tedarikci);

            await _unitOfWork.TedarikciService.AddAsync(tedarikci);
            return RedirectToAction(nameof(Index));
        }

        // Tedarikçi güncelleme sayfası (GET)
        public async Task<IActionResult> Guncelle(int id)
        {
            var tedarikci = await _unitOfWork.TedarikciService.GetByIdAsync(id);
            if (tedarikci == null)
                return NotFound();

            return View(tedarikci);
        }

        // Tedarikçi güncelleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Guncelle(Tedarikci tedarikci)
        {
            if (!ModelState.IsValid)
                return View(tedarikci);

            await _unitOfWork.TedarikciService.UpdateAsync(tedarikci);
            return RedirectToAction(nameof(Index));
        }

        // Tedarikçi silme işlemi
        public async Task<IActionResult> Sil(int id)
        {
            var tedarikci = await _unitOfWork.TedarikciService.GetByIdAsync(id);
            if (tedarikci == null)
                return NotFound();

            await _unitOfWork.TedarikciService.RemoveAsync(tedarikci);
            return RedirectToAction(nameof(Index));
        }
    }
}
