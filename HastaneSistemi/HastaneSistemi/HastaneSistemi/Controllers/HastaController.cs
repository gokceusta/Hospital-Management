using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{
    public class HastaController : Controller
    {
        public IActionResult HastaBilgi()
        {
            return View();
        }
    }
}
