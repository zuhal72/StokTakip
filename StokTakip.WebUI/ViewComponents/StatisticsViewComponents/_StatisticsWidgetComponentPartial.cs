using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;
using System.Linq;

namespace StokTakip.WebUI.ViewComponents.StatisticsViewComponents
{
    public class _StatisticsWidgetComponentPartial : ViewComponent
    {
        private readonly StokDbContext _context;

        public _StatisticsWidgetComponentPartial(StokDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
           
            // Kategori ve tedarikçi sayısı
            ViewBag.KategorilerCount = _context.Kategoriler.Count();
            ViewBag.TedarikcilerCount = _context.Tedarikciler.Count();

            // En fazla stok bilgisi (ürün adı + miktar)
            var maxStok = _context.Stoklar
                .OrderByDescending(x => x.Miktar)
                .Select(x => new { x.UrunAdi, x.Miktar })
                .FirstOrDefault();

            ViewBag.StoklarMaxCountUrunAdı = maxStok?.UrunAdi;
            ViewBag.StoklarMaxCount = maxStok?.Miktar;

            // En az stok bilgisi (ürün adı + miktar)
            var minStok = _context.Stoklar
                .OrderBy(x => x.Miktar)
                .Select(x => new { x.UrunAdi, x.Miktar })
                .FirstOrDefault();

            ViewBag.StoklarMinCountUrunAdı = minStok?.UrunAdi;
            ViewBag.StoklarMinCount = minStok?.Miktar;

            // En fazla ürün gönderen tedarikçi
            var grupVeri = _context.Stoklar
                .Include(x => x.Tedarikci)
                .ToList()
                .GroupBy(x => x.Tedarikci.Ad)
                .Select(g => new
                {
                    TedarikciAdi = g.Key,
                    ToplamMiktar = g.Sum(x => x.Miktar)
                })
                .OrderByDescending(x => x.ToplamMiktar)
                .FirstOrDefault();

            ViewBag.EnFazlaUrunTedarikci = grupVeri?.TedarikciAdi;
            ViewBag.EnFazlaUrunTedarikciMiktar = grupVeri?.ToplamMiktar;
            // En az ürün gönderen tedarikçi
            var grupVeriMin = _context.Stoklar
                .Include(x => x.Tedarikci)
                .ToList()
                .GroupBy(x => x.Tedarikci.Ad)
                .Select(g => new
                {
                    TedarikciAdi = g.Key,
                    ToplamMiktar = g.Sum(x => x.Miktar)
                })
                .Where(x => x.ToplamMiktar > 0)
                .OrderBy(x => x.ToplamMiktar)
                .FirstOrDefault();

            ViewBag.EnAzUrunTedarikci = grupVeriMin?.TedarikciAdi;
            ViewBag.EnAzUrunTedarikciMiktar = grupVeriMin?.ToplamMiktar;

            ViewBag.SumStoklarCount = _context.Stoklar.Sum(x => x.Miktar);

            var grupVeriler = _context.Stoklar
                .Include(x => x.Kategori)
                .ToList()
                .GroupBy(x => x.Kategori.Ad)
                .Select(g => new
                {
                    KategoriAdi = g.Key,
                    ToplamMiktar = g.Sum(x => x.Miktar)
                })
                .OrderByDescending(x => x.ToplamMiktar)
                .FirstOrDefault();

            ViewBag.EnFazlaUrunKategori = grupVeriler?.KategoriAdi;
            ViewBag.EnFazlaUrunKategoriMiktar = grupVeriler?.ToplamMiktar;
            // En az ürün gönderen tedarikçi
            var grupVerilerMin = _context.Stoklar
                .Include(x => x.Kategori)
                .ToList()
                .GroupBy(x => x.Kategori.Ad)
                .Select(g => new
                {
                    KategoriAdi = g.Key,
                    ToplamMiktar = g.Sum(x => x.Miktar)
                })
                .Where(x => x.ToplamMiktar > 0)
                .OrderBy(x => x.ToplamMiktar)
                .FirstOrDefault();

            ViewBag.EnAzUrunKategori = grupVerilerMin?.KategoriAdi;
            ViewBag.EnAzUrunKategoriMiktar = grupVerilerMin?.ToplamMiktar;

            return View();

            
        }
    }
}
