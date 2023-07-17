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
        public async Task<IActionResult> Index(RegisterViewModel model)
        {


            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.SurName,
                Email = model.Email,
                UserName = model.Username
            };
            if (model.Password == model.ConfirmPassword )
            {
               var result =  await _userManager.CreateAsync(appUser, model.Password);
                if(result.Succeeded) {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                
            }
            else
            {
                ModelState.AddModelError("", "şifreler eşleşmiyor");
            }
            return View();
            


        }
    }
}
