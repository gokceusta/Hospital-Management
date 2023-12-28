using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{
    public class KullanıcıController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
