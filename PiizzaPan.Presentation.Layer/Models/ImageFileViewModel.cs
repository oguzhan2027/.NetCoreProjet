using Microsoft.AspNetCore.Http;

namespace PiizzaPan.Presentation.Layer.Models
{
    public class ImageFileViewModel
    {
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
