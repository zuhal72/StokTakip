using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;

namespace StokTakip.WebUI.ViewComponents
{
    public class _TedarikciDashboardComponentPartial:ViewComponent
    {
        private readonly StokDbContext  _context;
        public _TedarikciDashboardComponentPartial ( StokDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Stoklar.Include(x => x.Tedarikci).OrderByDescending(x => x.Id).Take(5).ToList();
            return View(values);
        }

    }
}
