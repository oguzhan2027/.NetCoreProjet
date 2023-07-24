using Microsoft.AspNetCore.Http;

namespace PiizzaPan.Presentation.Layer.Models
{
    public class GalleryViewModel
    {

        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
