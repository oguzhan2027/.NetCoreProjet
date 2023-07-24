using Microsoft.AspNetCore.Mvc;
using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Bussiness.Layer.Abstract;

namespace PiizzaPan.Presentation.Layer.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values = _contactUsService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateContactUs(int id)
        {
            var value = _contactUsService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContactUs(ContactUs p)
        {
            _contactUsService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
