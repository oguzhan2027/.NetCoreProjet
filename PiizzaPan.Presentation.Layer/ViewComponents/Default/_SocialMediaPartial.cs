using Microsoft.AspNetCore.Mvc;
using PiizzaPan.Bussiness.Layer.Abstract;

namespace PiizzaPan.Presentation.Layer.ViewComponents.Default
{
    public class _SocialMedia : ViewComponent
    {
        private readonly ISocialMadiaService _socialMediaService;

        public _SocialMedia(ISocialMadiaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetList();
            return View(values);
        }
    }
}
