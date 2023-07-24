using Microsoft.AspNetCore.Mvc;
using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Bussiness.Layer.Abstract;
using System.IO;
using System;
using PiizzaPan.Presentation.Layer.Models;

namespace PiizzaPan.Presentation.Layer.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(TestimonialViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.FileName);
            var imageName = Guid.NewGuid() + extension; //guid benzersiz 32 hanelik bir isim
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            model.Image.CopyTo(stream);
            Testimonial testimonial = new Testimonial();
            testimonial.CustomerName = model.CustomerName;
            testimonial.CustomerTitle = model.CustomerTitle;
            testimonial.Comment = model.Comment;
            testimonial.ImageUrl = imageName;
            _testimonialService.TInsert(testimonial);

            return RedirectToAction("Index");
        }


        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return RedirectToAction("Index");
        }

    }
}
