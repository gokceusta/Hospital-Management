using HastaneSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HastaneSistemi.Controllers
{
    public class DoktorController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Doktors.Include(x=>x.Poliklinik).ToList();
            return View(degerler);
        }
    }
}
