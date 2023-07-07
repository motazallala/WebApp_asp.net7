using Microsoft.AspNetCore.Mvc;

namespace Co132.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
    }
}

