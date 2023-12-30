using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{
  
    public class KayitController : Controller
    {
        public IActionResult Kayit()
        {
            return View();
        }
    }
}
