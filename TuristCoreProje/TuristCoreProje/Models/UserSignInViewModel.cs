using System.ComponentModel.DataAnnotations;

namespace TuristCoreProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz.")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz.")]
        public string Password { get; set; }
    }
}
