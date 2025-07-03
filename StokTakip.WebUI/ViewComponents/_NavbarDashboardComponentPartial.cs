using Microsoft.AspNetCore.Mvc;

namespace StokTakip.WebUI.ViewComponents
{
    public class _NavbarDashboardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
