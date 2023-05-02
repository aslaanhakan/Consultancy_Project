using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Consultancy_Project.MVC.Models
{
    public class RegisterViewModel
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "Ad alanı zorunludur")]
        public string FirstName { get; set; }

        [DisplayName("Soyad")]
        [Required(ErrorMessage = "Soyad alanı zorunludur")]
        public string LastName { get; set; }
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı boş bırakılmamalıdır")]
        public string UserName { get; set; }
        [DisplayName("Eposta")]
        [Required(ErrorMessage = "Eposta boş bırakılmamalıdır")]
        public string Email { get; set; }

        [DisplayName("Parola")]
        [Required(ErrorMessage = "Parola boş bırakılmamalıdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Parola Tekrar")]
        [Required(ErrorMessage = "Parola tekrar alanı zorunludur")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "İki parola aynı olmalıdır!")]
        public string RePassword { get; set; }

    }
}
