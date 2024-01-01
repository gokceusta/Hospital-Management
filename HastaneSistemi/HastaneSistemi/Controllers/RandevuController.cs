using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
    
{
    [Authorize]
    public class RandevuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
