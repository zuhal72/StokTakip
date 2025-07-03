using Microsoft.AspNetCore.Mvc;

namespace StokTakip.WebUI.ViewComponents
{
    public class _SidebarDashboardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
