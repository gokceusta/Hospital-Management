using HastaneSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{
    public class DoktorController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Doktors.ToList();
            return View(degerler);
        }
    }
}
