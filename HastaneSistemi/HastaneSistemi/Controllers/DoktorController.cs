using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{
    public class DoktorController : Controller
    {
        public IActionResult DoktorBilgi()
        {
            return View();
        }
    }
}
