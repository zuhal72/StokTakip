using Microsoft.AspNetCore.Mvc;
using StokTakip.DataAccess.Context;

namespace StokTakip.WebUI.ViewComponents
{
    public class _CardStatisticsDashboardComponentPartial:ViewComponent
    {
        private readonly StokDbContext _context;

        public _CardStatisticsDashboardComponentPartial(StokDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.totalTedarikciCount = _context.Tedarikciler.Count();
            ViewBag.totalKategoriCount = _context.Kategoriler.Count();
            ViewBag.totalStokCount = _context.Stoklar.Count();
            ViewBag.totalDepoCount = _context.Depolar.Count();
            ViewBag.totalBirimCount = _context.Birimler.Count();
            ViewBag.sumStoklarCount = _context.Stoklar.Sum(x => x.Miktar);
                return View();
        }
    }
}
