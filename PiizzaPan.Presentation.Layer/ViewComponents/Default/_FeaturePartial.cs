using Microsoft.AspNetCore.Mvc;

namespace PiizzaPan.Presentation.Layer.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Her Gün Pizza Yiyin";
            ViewBag.title2 = "Sevdiğiniz Pizzaları Paylaşın";

            return View();
        }
    }
}
