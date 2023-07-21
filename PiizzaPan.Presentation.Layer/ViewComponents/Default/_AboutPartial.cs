using Microsoft.AspNetCore.Mvc;

namespace PiizzaPan.Presentation.Layer.ViewComponents.Default
{
    public class _AboutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
