using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{
    public class DepartmanController : Controller
    {
        public IActionResult DepartmanBilgi()
        {
            return View();
        }
    }
}
