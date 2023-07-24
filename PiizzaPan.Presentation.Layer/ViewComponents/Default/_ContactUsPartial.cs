using Microsoft.AspNetCore.Mvc;
using PiizzaPan.Bussiness.Layer.Abstract;

namespace PiizzaPan.Presentation.Layer.ViewComponents.Default
{
    public class _ContactUsPartial : ViewComponent
    {
        private readonly IContactUsService _contactUsService;

        public _ContactUsPartial(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactUsService.TGetById(1);

            ViewBag.title = value.Title;
            ViewBag.image = value.ImageUrl;
            ViewBag.address = value.Address;
            ViewBag.phone = value.Phone;
            ViewBag.mail = value.Mail;
            ViewBag.date = value.StartEndDate;

            return View();
        }
    }
}
