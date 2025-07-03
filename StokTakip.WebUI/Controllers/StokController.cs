using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StokTakip.Services.IServices;
using StokTakip.Entities.Entities;

namespace StokTakip.WebUI.Controllers
{
    public class StokController : Controller
    {
        private readonly IUnitOfWorkService _unitOfWork;
        private readonly DbContext _context;
        
        public StokController(IUnitOfWorkService unitOfWork, DbContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        // Tüm stokları kategori ve birim bilgileriyle listele
        public async Task<IActionResult> Index()
        {
            var stoklar = await _unitOfWork.StokService.GetStoklarWithKategoriAndBirimAsync();
            return View(stoklar);
        }

        // Stok detaylarını getir (kategori, birim vb. detaylarla)
        public async Task<IActionResult> Detay(int id)
        {
            var stok = await _unitOfWork.StokService.GetStokWithDetailsByIdAsync(id);
            if (stok == null)
                return NotFound();

            return View(stok);
        }

       
        // Yeni stok ekleme sayfası (GET)
        public IActionResult Ekle()
        {
            return View();
        }

        // Yeni stok ekleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Stok stok)
        {
            if (!ModelState.IsValid)
                return View(stok);

            await _unitOfWork.StokService.AddAsync(stok);
            return RedirectToAction(nameof(Index));
        }

        // Stok güncelleme sayfası (GET)
        public async Task<IActionResult> Guncelle(int id)
        {
            var stok = await _unitOfWork.StokService.GetByIdAsync(id);
            if (stok == null)
                return NotFound();

            return View(stok);
        }

        // Stok güncelleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Guncelle(Stok stok)
        {
            if (!ModelState.IsValid)
                return View(stok);

            await _unitOfWork.StokService.UpdateAsync(stok);
            return RedirectToAction(nameof(Index));
        }

        // Stok silme işlemi
        public async Task<IActionResult> Sil(int id)
        {
            var stok = await _unitOfWork.StokService.GetByIdAsync(id);
            if (stok == null)
                return NotFound();

            await _unitOfWork.StokService.RemoveAsync(stok);
            return RedirectToAction(nameof(Index));
        }
    }
}
