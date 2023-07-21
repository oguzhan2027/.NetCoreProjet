using Microsoft.AspNetCore.Mvc;

namespace PiizzaPan.Presentation.Layer.ViewComponents.Default
{
    public class _GalleryPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
