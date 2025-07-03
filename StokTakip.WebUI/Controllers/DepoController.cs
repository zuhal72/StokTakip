using Microsoft.AspNetCore.Mvc;
using StokTakip.Entities.Entities;
using StokTakip.Services.IServices;

namespace StokTakip.WebUI.Controllers
{
    public class DepoController : Controller
    {
        private readonly IUnitOfWorkService _unitOfWork;

        public DepoController(IUnitOfWorkService unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Tüm Depoları Listele
        public async Task<IActionResult> Index()
        {
            var depolar = await _unitOfWork.DepoService.GetAllAsync();
            return View(depolar);
        }

        // Detayları Görüntüle
        public async Task<IActionResult> Detay(int id)
        {
            var depo = await _unitOfWork.DepoService.GetByIdAsync(id);
            if (depo == null)
                return NotFound();

            return View(depo);
        }

        // Yeni Depo Ekle (GET)
        public IActionResult Ekle()
        {
            return View();
        }

        // Yeni Depo Ekle (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Depo depo)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.DepoService.AddAsync(depo);
                return RedirectToAction(nameof(Index));
            }
            return View(depo);
        }

        // Depo Güncelle (GET)
        public async Task<IActionResult> Guncelle(int id)
        {
            var depo = await _unitOfWork.DepoService.GetByIdAsync(id);
            if (depo == null)
                return NotFound();

            return View(depo);
        }

        // Depo Güncelle (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Guncelle(Depo depo)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.DepoService.UpdateAsync(depo);
                return RedirectToAction(nameof(Index));
            }
            return View(depo);
        }

        // Depo Sil
        public async Task<IActionResult> Sil(int id)
        {
            var depo = await _unitOfWork.DepoService.GetByIdAsync(id);
            if (depo == null)
                return NotFound();

            await _unitOfWork.DepoService.RemoveAsync(depo);
            return RedirectToAction(nameof(Index));
        }
    }
}
