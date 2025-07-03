using Microsoft.AspNetCore.Mvc;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.WebUI.Controllers
{
    public class StokHareketController : Controller
    {
        private readonly IUnitOfWorkService _unitOfWork;

        public StokHareketController(IUnitOfWorkService unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Tüm stok hareketlerini detaylarıyla listele
        public async Task<IActionResult> Index()
        {
            var hareketler = await _unitOfWork.StokHareketService.GetHareketlerWithDetailsAsync();
            return View(hareketler);
        }

        // Belirli bir stokun hareketlerini listele
        public async Task<IActionResult> StokHareketleri(int stokId)
        {
            var hareketler = await _unitOfWork.StokHareketService.GetHareketlerByStokIdAsync(stokId);
            return View(hareketler);
        }

        // Yeni stok hareketi ekleme sayfası (GET)
        public IActionResult Ekle()
        {
            return View();
        }

        // Yeni stok hareketi ekleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(StokHareket hareket)
        {
            if (!ModelState.IsValid)
                return View(hareket);

            await _unitOfWork.StokHareketService.AddAsync(hareket);
            return RedirectToAction(nameof(Index));
        }

        // Stok hareketi güncelleme sayfası (GET)
        public async Task<IActionResult> Guncelle(int id)
        {
            var hareket = await _unitOfWork.StokHareketService.GetByIdAsync(id);
            if (hareket == null)
                return NotFound();

            return View(hareket);
        }

        // Stok hareketi güncelleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Guncelle(StokHareket hareket)
        {
            if (!ModelState.IsValid)
                return View(hareket);

            await _unitOfWork.StokHareketService.UpdateAsync(hareket);
            return RedirectToAction(nameof(Index));
        }

        // Stok hareketi silme işlemi
        public async Task<IActionResult> Sil(int id)
        {
            var hareket = await _unitOfWork.StokHareketService.GetByIdAsync(id);
            if (hareket == null)
                return NotFound();

            await _unitOfWork.StokHareketService.RemoveAsync(hareket);
            return RedirectToAction(nameof(Index));
        }
    }
}
