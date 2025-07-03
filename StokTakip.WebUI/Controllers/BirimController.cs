using Microsoft.AspNetCore.Mvc;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.WebUI.Controllers
{
    public class BirimController : Controller
    {
        private readonly IUnitOfWorkService _unitOfWork;

        public BirimController(IUnitOfWorkService unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Tüm birimleri listele
        public async Task<IActionResult> Index()
        {
            var birimler = await _unitOfWork.BirimService.GetAllAsync();
            return View(birimler);
        }

        // Detay (Stoklarıyla birlikte)
        public async Task<IActionResult> Detay(int id)
        {
            var birim = await _unitOfWork.BirimService.GetBirimWithStokAsync(id);
            if (birim == null)
            {
                return NotFound();
            }

            return View(birim);
        }

        // Yeni birim ekleme (GET)
        public IActionResult Ekle()
        {
            return View();
        }

        // Yeni birim ekleme (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Birim birim)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.BirimService.AddAsync(birim);
                return RedirectToAction(nameof(Index));
            }
            return View(birim);
        }

        // Güncelleme (GET)
        public async Task<IActionResult> Guncelle(int id)
        {
            var birim = await _unitOfWork.BirimService.GetByIdAsync(id);
            if (birim == null)
            {
                return NotFound();
            }
            return View(birim);
        }

        // Güncelleme (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Guncelle(Birim birim)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.BirimService.UpdateAsync(birim);
                return RedirectToAction(nameof(Index));
            }
            return View(birim);
        }

        // Silme
        public async Task<IActionResult> Sil(int id)
        {
            var birim = await _unitOfWork.BirimService.GetByIdAsync(id);
            if (birim == null)
            {
                return NotFound();
            }

            await _unitOfWork.BirimService.RemoveAsync(birim);
            return RedirectToAction(nameof(Index));
        }
    }
}
