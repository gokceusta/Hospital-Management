using HastaneSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult BirimIncele(int id)
        {
            var degerler = c.Doktors.Where(x => x.PoliklinikID == id).Include(x => x.Poliklinik).ToList();
            return View(degerler);
        }
    }
}
