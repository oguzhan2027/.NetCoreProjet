using Microsoft.AspNetCore.Mvc;

namespace PiizzaPan.Presentation.Layer.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
