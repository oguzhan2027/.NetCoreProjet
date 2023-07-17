using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Presentation.Layer.Models;
using System;
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
            Random rnd = new Random();
            int x = rnd.Next(100000, 1000000);

            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.SurName,
                Email = model.Email,
                UserName = model.Username,
                ConfirmCode=x
            };
            if (model.Password == model.ConfirmPassword )
            {
                
                var result =  await _userManager.CreateAsync(appUser, model.Password);
                if(result.Succeeded) {
                    #region
                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "oguzhancelik2027@gmail.com");
                    mimeMessage.From.Add(mailboxAddressFrom);

                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.Email);
                    mimeMessage.To.Add(mailboxAddressTo);

                    var bodybuilder = new BodyBuilder();
                    bodybuilder.TextBody = "Giriş yapabilmek için onaylama kodunuz:" + x;
                    mimeMessage.Body = bodybuilder.ToMessageBody();

                    mimeMessage.Subject = "doğrulama kodu";

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Connect("smtp.gmail.com", 587, false);
                    smtpClient.Authenticate("oguzhancelik2027@gmail.com", "eyupgcdosuxawwuu");
                    smtpClient.Send(mimeMessage);
                    smtpClient.Disconnect(true);

                    #endregion

                    TempData["Username"] = appUser.UserName;
                    return RedirectToAction("Index", "ConfirmEmail");
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
