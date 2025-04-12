using System.ComponentModel.DataAnnotations;

namespace IdentityDataProtection.Models
{
    public class UserRegister
    {
        [Required(ErrorMessage = "Email adresi alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Password { get; set; }
    }
}