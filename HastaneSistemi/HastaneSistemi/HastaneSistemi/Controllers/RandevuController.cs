using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{
    public class RandevuController : Controller
    {
        public IActionResult RandevuBilgi()
        {
            return View();
        }
    }
}
