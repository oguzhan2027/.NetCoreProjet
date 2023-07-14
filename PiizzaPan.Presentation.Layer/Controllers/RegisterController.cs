using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Presentation.Layer.Models;
using System.Threading.Tasks;

namespace PiizzaPan.Presentation.Layer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Index(RegisterViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = model.Name,
                    Surname = model.SurName,
                    Email = model.Email,
                    UserName = model.Username
                };

                await _userManager.CreateAsync(appUser, model.Password);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }
    }
}
