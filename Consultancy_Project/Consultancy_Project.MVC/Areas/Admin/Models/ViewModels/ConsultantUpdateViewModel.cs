using Consultancy_Project.Entity.Concrate;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Consultancy_Project.MVC.Areas.Admin.Models.ViewModels
{
    public class ConsultantUpdateViewModel
    {
        public int ConsultantId { get; set; }
        [DisplayName("Ad")]
        [Required(ErrorMessage = "Ad alanı boş bırakılmamaz.")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "Soyad alanı boş bırakılmamaz.")]
        public string LastName { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string? UserName { get; set; }
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
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email alanı boş bırakılmamaz.")]
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
        [DisplayName("Tanıtım Yazısı")]
        public string Promotion { get; set; }
        [DisplayName("Seans Ücreti")]
        public decimal? VisitsPrice { get; set; }
        [DisplayName("Unvan")]
        public string JobTitle { get; set; }
        public  List<Education> Educations { get; set; }
        [DisplayName("Üniversite")]

        public string SchoolName { get; set; }
        [DisplayName("Fakülte")]

        public string FacultyName { get; set; }
        [DisplayName("Bölüm")]

        public string DepartmentName { get; set; }
        [DisplayName("Eğitim Derecesi")]

        public string DegreeofGraduation { get; set; }
        [DisplayName("Başlama Yılı")]

        public int StartYear { get; set; }
        [DisplayName("Bitirme Yılı")]

        public int GraduationYear { get; set; }
        public  List<Specialization> Specializations { get; set; }
        public List<Specialization> NonSpecialization { get; set; }
        public string[] IdsToAddSpecialization { get; set; }
        public string[] IdsToRemoveSpecialization { get; set; }
        public  List<Certificate> Certificates { get; set; }
        [DisplayName("Kurum Adı")]

        public string Institution { get; set; }
        [DisplayName("Sertifika Adı")]

        public string CertificateName { get; set; }
        [DisplayName("Sertifika Yılı")]

        public int CertificateTime { get; set; }
    }
}
