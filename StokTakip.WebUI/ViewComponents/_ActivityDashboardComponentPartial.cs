using Microsoft.AspNetCore.Mvc;
using StokTakip.DataAccess.Context;

namespace StokTakip.WebUI.ViewComponents
{
    public class _ActivityDashboardComponentPartial:ViewComponent
    {
        private readonly StokDbContext _context;

        public _ActivityDashboardComponentPartial(StokDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Activities.OrderByDescending(x => x.ActivityId).Take(5).ToList();
            return View(values);
        }
    }
}
