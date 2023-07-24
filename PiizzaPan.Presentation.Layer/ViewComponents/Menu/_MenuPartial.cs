using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PiizzaPan.Bussiness.Layer.Abstract;
using PiizzaPan.DataAccessLayer.Concrete;
using System.Linq;

namespace PiizzaPan.Presentation.Layer.ViewComponents.Menu
{
    public class _MenuPartial : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly Context _context;

        public _MenuPartial(IProductService productService, Context context)
        {
            _productService = productService;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            var values = _context.Categories.Include(x => x.Products).ToList();
            return View(values);
        }
    }
}
