using Microsoft.AspNetCore.Mvc;

namespace PiizzaPan.Presentation.Layer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
