using Microsoft.AspNetCore.Mvc;

namespace StokTakip.WebUI.ViewComponents
{
    public class _ChartDashboardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
