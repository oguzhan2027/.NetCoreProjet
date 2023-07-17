using Microsoft.AspNetCore.Mvc;

namespace PiizzaPan.Presentation.Layer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
