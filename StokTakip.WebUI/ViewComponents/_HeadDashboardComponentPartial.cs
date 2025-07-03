using Microsoft.AspNetCore.Mvc;

namespace StokTakip.WebUI.ViewComponents
{
    public class _HeadDashboardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
