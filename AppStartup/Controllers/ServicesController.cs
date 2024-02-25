using AppStartup.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppStartup.Controllers
{
    public class ServicesController : Controller
    {
        private List<ServicesModel> serviceList = ServicesModel.GetServices();

        public IActionResult Services()
        {
            return View(serviceList);
        }
    }
}
