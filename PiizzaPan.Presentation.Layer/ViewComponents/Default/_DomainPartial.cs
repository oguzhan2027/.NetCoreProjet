using Microsoft.AspNetCore.Mvc;

namespace PiizzaPan.Presentation.Layer.ViewComponents.Default
{
    public class _DomainPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
