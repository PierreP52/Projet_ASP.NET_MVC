using AppStartup.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppStartup.Controllers
{
    public class NousJoindreController : Controller
    {

        public IActionResult Confirmation()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(NousJoindreModel joindre)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Confirmation");

            }
            return View(joindre);
        }
    }
}
