using Microsoft.AspNetCore.Mvc;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.WebUI.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IUnitOfWorkService _unitOfWork;

        public KategoriController(IUnitOfWorkService unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Tüm kategorileri listele
        public async Task<IActionResult> CategoryList()
        {
            var kategoriler =await _unitOfWork.KategoriService.GetAllAsync();
            return View(kategoriler);
        }

        // Kategori detayları (ilişkili stoklar ile)
        public async Task<IActionResult> Detay(int id)
        {
            var kategori = await _unitOfWork.KategoriService.GetKategoriWithStoklarAsync(id);
            if (kategori == null)
                return NotFound();

            return View(kategori);
        }

        // Yeni kategori ekleme sayfası (GET)
        public IActionResult Ekle()
        {
            return View();
        }

        // Yeni kategori ekleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Kategori kategori)
        {
            if (!ModelState.IsValid)
                return View(kategori);

            await _unitOfWork.KategoriService.AddAsync(kategori);
            return RedirectToAction(nameof(Index));
        }

        // Kategori güncelleme sayfası (GET)
        public async Task<IActionResult> Guncelle(int id)
        {
            var kategori = await _unitOfWork.KategoriService.GetByIdAsync(id);
            if (kategori == null)
                return NotFound();

            return View(kategori);
        }

        // Kategori güncelleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Guncelle(Kategori kategori)
        {
            if (!ModelState.IsValid)
                return View(kategori);

            await _unitOfWork.KategoriService.UpdateAsync(kategori);
            return RedirectToAction(nameof(Index));
        }

        // Kategori silme işlemi
        public async Task<IActionResult> Sil(int id)
        {
            var kategori = await _unitOfWork.KategoriService.GetByIdAsync(id);
            if (kategori == null)
                return NotFound();

            await _unitOfWork.KategoriService.RemoveAsync(kategori);
            return RedirectToAction(nameof(Index));
        }
    }
}
