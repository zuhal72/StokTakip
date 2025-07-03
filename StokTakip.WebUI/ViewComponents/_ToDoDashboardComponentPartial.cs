using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StokTakip.DataAccess.Context;

namespace StokTakip.WebUI.ViewComponents
{
    public class _ToDoDashboardComponentPartial : ViewComponent
    {
        private readonly StokDbContext _context;

        public _ToDoDashboardComponentPartial(StokDbContext context) // Constructor injection
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Todos.OrderByDescending(x => x.TodoId).Take(6).ToList();
            return View(values);
        }
    }
}
