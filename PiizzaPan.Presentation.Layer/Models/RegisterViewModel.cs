using System.ComponentModel.DataAnnotations;

namespace PiizzaPan.Presentation.Layer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Ad alanı boş geçilmez")]
        public string Name { get; set; }
        public string SurName { get; set; }

        [Required(ErrorMessage ="Email alanı boş geçilmez")]
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
