using Microsoft.AspNetCore.Mvc;
using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Bussiness.Layer.Abstract;

namespace PiizzaPan.Presentation.Layer.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public IActionResult Index()
        {
            
            var values = _menuService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddMenu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMenu(Menu menu)
        {
            _menuService.TInsert(menu);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMenu(int id)
        {
            var value = _menuService.TGetByID(id);
            _menuService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateMenu(int id)
        {
            var value = _menuService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateMenu(Menu menu)
        {
            _menuService.TUpdate(menu);
            return RedirectToAction("Index");
        }
    }
}
