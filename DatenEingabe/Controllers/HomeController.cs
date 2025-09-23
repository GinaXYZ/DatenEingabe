using Microsoft.AspNetCore.Mvc;

namespace DatenEingabe.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatenEingabe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DatenEingabe(string Vorname, string Nachname, DateOnly Geburtsdatum)
        {

            return RedirectToAction("Index");
        }
    }
}
