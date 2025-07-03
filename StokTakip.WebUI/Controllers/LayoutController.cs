using Microsoft.AspNetCore.Mvc;

namespace StokTakip.WebUI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
