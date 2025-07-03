using Microsoft.AspNetCore.Mvc;

namespace StokTakip.WebUI.ViewComponents
{
    public class _StokStatusDashboardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
