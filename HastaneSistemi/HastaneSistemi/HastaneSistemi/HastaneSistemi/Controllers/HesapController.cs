using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{

    public class HesapController : Controller
    {
        public IActionResult Giris()
        {
            return View();
        }

    }
}
