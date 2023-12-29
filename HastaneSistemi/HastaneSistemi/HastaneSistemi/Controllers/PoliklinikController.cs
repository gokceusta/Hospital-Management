using HastaneSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneSistemi.Controllers
{
    public class PoliklinikController : Controller
    {
        Context c = new Context();  
        public IActionResult Index()
        {
            var degerler = c.Polikliniks.ToList();
            return View(degerler);
        }
    }
}
