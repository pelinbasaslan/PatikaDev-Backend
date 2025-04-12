using System.ComponentModel.DataAnnotations;

namespace IdentityDataProtection.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Eposta adresi girmek gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre girmek zorunlu")]
        public string Password { get; set; }
    }
}