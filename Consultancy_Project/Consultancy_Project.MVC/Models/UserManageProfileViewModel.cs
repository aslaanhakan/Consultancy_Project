using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Consultancy_Project.MVC.Models
{
    public class UserManageProfileViewModel
    {
        public string Id { get; set; }
        [DisplayName("Ad")]
        [Required(ErrorMessage = "Ad alanı boş bırakılmamaz.")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "Soyad alanı boş bırakılmamaz.")]
        public string LastName { get; set; }
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı alanı boş bırakılmamaz.")]
        public string UserName { get; set; }
        [DisplayName("Cinsiyet")]
        public string? Gender { get; set; }
        [DisplayName("Doğum Günü")]
        public DateTime? DateOfBirth { get; set; }
        [DisplayName("Adres")]
        public string? Address { get; set; }
        [DisplayName("Şehir")]
        public string? City { get; set; }
        public IFormFile? ImageFile { get; set; }

        public string? ImageUrl { get; set; }
        [DisplayName("Eposta")]
        [Required(ErrorMessage = "Eposta adresi boş bırakılamaz")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Telefon")]
        public string? Phone { get; set; }
        [DisplayName("Oluşturma Zamanı")]
        public DateTime? CreatedTime { get; set; }
        [DisplayName("Güncellenme Zamanı")]
        public DateTime? UpdateTime { get; set; }
        [DisplayName("Telefon Doğrulaması")]
        public bool PhoneConfirmed { get; set; }
        [DisplayName("Email Doğrulaması")]
        public bool EmailConfirmed { get; set; }        
        public List<SelectListItem> GenderSelectList { get; set; }
    }
}
