using Microsoft.AspNetCore.Http;

namespace PiizzaPan.Presentation.Layer.Models
{
    public class TestimonialViewModel
    {
        public string CustomerName { get; set; }
        public string CustomerTitle { get; set; }
        public string Comment { get; set; }
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
    }
}
