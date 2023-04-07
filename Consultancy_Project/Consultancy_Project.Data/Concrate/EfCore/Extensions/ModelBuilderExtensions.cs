using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Concrate.EfCore.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Certificates
            List<Certificate> certificates = new List<Certificate> {
               new Certificate { CertificateName = "Psikolojik Danışmanlık Sertifikası", Institution = "Amerikan Psikoloji Derneği" },
               new Certificate { CertificateName = "Psikologlar için Uzmanlık Sertifikası", Institution = "Amerikan Psikoloji Derneği (APA)" },
               new Certificate { CertificateName = "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", Institution = "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)" },
               new Certificate { CertificateName = "Avrupa Psikolog (EuroPsy) Sertifikası", Institution = "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)" },
               new Certificate { CertificateName = "Kognitif Davranış Terapisi (KDT) Sertifikası", Institution = "İngiliz Psikoloji Derneği (British Psychological Society, BPS)" },
                new Certificate { CertificateName = "Psikologlar için Özel Uzmanlık Sertifikası", Institution = "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)" },
                new Certificate { CertificateName = "Psikodrama Uzmanlık Sertifikası", Institution = "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)" },
                new Certificate { CertificateName = "Sanat Terapisi Sertifikası", Institution = "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)" },
                new Certificate { CertificateName = "Hipnoterapi Sertifikası", Institution = "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)" },
                new Certificate { CertificateName = "Oyun Terapisi Sertifikası", Institution = "Oyun Terapisi Derneği (Association for Play Therapy, APT)" },
                new Certificate { CertificateName = "Çift ve Aile Terapisi Sertifikası", Institution = "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)" }
            };
            modelBuilder.Entity<Certificate>().HasData(certificates);
            #endregion

            #region Users
            List<User> users = new List<User>
            {
                new User{FirstName="Ayşe",
                    LastName="Yılmaz",
                    UserName="ayseyilmaz",
                    NormalizedUserName="AYSEYILMAZ",
                    Email="ayse.yilmaz@gmail.com",
                    NormalizedEmail="AYSE.YILMAZ@GMAIL.COM",
                    Gender="Kadın",
                    DateOfBirth=new DateTime(1992,3,14),
                    Address="Cemal Gürsel Cd. No:5 Kadıköy",
                    City="İstanbul",
                    EmailConfirmed=true },

new User{FirstName="Mehmet",
    LastName="Özkan",
    UserName="mehmetozkan",
    NormalizedUserName="MEHMETOZKAN",
    Email="mehmet.ozkan@gmail.com",
    NormalizedEmail="MEHMET.OZKAN@GMAIL.COM",
    Gender="Erkek",
    DateOfBirth=new DateTime(1988,11,23),
    Address="Atatürk Cd. No:15/4 Çankaya",
    City="Ankara", EmailConfirmed=true },

new User{FirstName="Zeynep", LastName="Güneş", UserName="zeynepgunes", NormalizedUserName="ZEYNEPGUNES", Email="zeynep.gunes@gmail.com", NormalizedEmail="ZEYNEP.GUNES@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1995,6,30), Address="Karşıyaka Cd. No:8/3 Alsancak", City="İzmir", EmailConfirmed=true },

new User{FirstName="Ali", LastName="Demir", UserName="alidemir", NormalizedUserName="ALIDEMIR", Email="ali.demir@gmail.com", NormalizedEmail="ALI.DEMIR@GMAIL.COM", Gender="Erkek", DateOfBirth=new DateTime(1990,2,8), Address="Atatürk Mah. No:4 Bahçelievler", City="İstanbul", EmailConfirmed=true },

new User{FirstName="Gizem", LastName="Aydın", UserName="gizemaydin", NormalizedUserName="GIZEMAYDIN", Email="gizem.aydin@gmail.com", NormalizedEmail="GIZEM.AYDIN@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1987,9,18), Address="Mecidiyeköy Cd. No:23 Şişli", City="İstanbul", EmailConfirmed=true },

new User{FirstName="Can", LastName="Ergün", UserName="canergun", NormalizedUserName="CANERGUN", Email="can.ergun@gmail.com", NormalizedEmail="CAN.ERGUN@GMAIL.COM", Gender="Erkek", DateOfBirth=new DateTime(1993,12,10), Address="Turan Cd. No:7 Bornova", City="İzmir", EmailConfirmed=true },

            new User
{
    FirstName = "Deniz",
    LastName = "Kartal",
    UserName = "deniz",
    NormalizedUserName = "DENIZ",
    Email = "deniz@asdasd.com",
    NormalizedEmail = "DENIZ@ASDASD.COM",
    Gender = "Kadın",
    DateOfBirth = new DateTime(1985, 5, 18),
    Address = "Halilpaşa Konağı Ap. No:18 Beşiktaş",
    City = "İstanbul",
    EmailConfirmed = true
},
new User
{
    FirstName = "Ali",
    LastName = "Yıldırım",
    UserName = "aliyildirim",
    NormalizedUserName = "ALIYILDIRIM",
    Email = "ali.yildirim@hotmail.com",
    NormalizedEmail = "ALI.YILDIRIM@HOTMAIL.COM",
    Gender = "Erkek",
    DateOfBirth = new DateTime(1992, 9, 5),
    Address = "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli",
    City = "İstanbul",
    EmailConfirmed = true
},
new User
{
    FirstName = "Melis",
    LastName = "Öztürk",
    UserName = "melisozturk",
    NormalizedUserName = "MELISOZTURK",
    Email = "melis.ozturk@gmail.com",
    NormalizedEmail = "MELIS.OZTURK@GMAIL.COM",
    Gender = "Kadın",
    DateOfBirth = new DateTime(1988, 2, 14),
    Address = "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli",
    City = "İstanbul",
    EmailConfirmed = true
},
new User
{
    FirstName = "Can",
    LastName = "Şahin",
    UserName = "cansahin",
    NormalizedUserName = "CANSAHIN",
    Email = "can.sahin@hotmail.com",
    NormalizedEmail = "CAN.SAHIN@HOTMAIL.COM",
    Gender = "Erkek",
    DateOfBirth = new DateTime(1995, 7, 22),
    Address = "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli",
    City = "İstanbul",
    EmailConfirmed = true
},
new User
{
    FirstName = "Esra",
    LastName = "Avcı",
    UserName = "esraavci",
    NormalizedUserName = "ESRAAVCI",
    Email = "esra.avci@gmail.com",
    NormalizedEmail = "ESRA.AVCI@GMAIL.COM",
    Gender = "Kadın",
    DateOfBirth = new DateTime(1983, 11, 3),
    Address = "Etiler Mah. Bebek Cad. No:17 Beşiktaş",
    City = "İstanbul",
    EmailConfirmed = true
},new User{FirstName="Fatma", LastName="Kara", UserName="fatmakara", NormalizedUserName="FATMAKARA", Email="fatma.kara@gmail.com", NormalizedEmail="FATMA.KARA@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1997,8,2), Address="İnönü Cd. No:12/1 Kartal", City="İstanbul",EmailConfirmed = true }
            };
            modelBuilder.Entity<User>().HasData(users);

            #endregion

            #region Specializations
            List<Specialization> specializations = new List<Specialization>()
            {  new Specialization { Name = "Depresyon", Description = "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak." },
                new Specialization { Name = "Kaygı Bozukluğu", Description = "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak." },

                new Specialization { Name = "Bağımlılık", Description = "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak." },

                 new Specialization { Name = "Öfke Kontrolü", Description = "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak." },

                new Specialization { Name = "Aile Terapisi", Description = "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak." },

                 new Specialization { Name = "Stres Yönetimi", Description = "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak." },

           new Specialization { Name = "Kişisel Gelişim", Description = "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak." },

         new Specialization { Name = "Cinsel Sorunlar", Description = "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak." },

         new Specialization { Name = "Çift Terapisi", Description = "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak." },

           new Specialization { Name = "Travma Sonrası Stres Bozukluğu", Description = "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak." },

         new Specialization { Name = "Yeme Bozuklukları", Description = "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak." }};
            modelBuilder.Entity<Specialization>().HasData(specializations);

            #endregion

            #region Educations
            List<Education> educations = new List<Education>()
            {
                new Education { SchoolName = "Anadolu Üniversitesi", FacultyName = "İktisadi ve İdari Bilimler Fakültesi", DepartmentName = "Psikolojik Danışmanlık ve Rehberlik", StartYear = 2009, GraduationYear = 2013, DegreeofGraduation="Lisans" },
new Education { SchoolName = "Hacettepe Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2011, GraduationYear = 2015, DegreeofGraduation="Lisans" },
new Education { SchoolName = "Dokuz Eylül Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2012, GraduationYear = 2016, DegreeofGraduation="Lisans" },
new Education { SchoolName = "Gazi Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Psikolojik Danışmanlık ve Rehberlik", StartYear = 2013, GraduationYear = 2017, DegreeofGraduation="Lisans" },
new Education { SchoolName = "Marmara Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2014, GraduationYear = 2018, DegreeofGraduation="Lisans" },
new Education { SchoolName = "Gazi Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Özel Eğitim", StartYear = 2011, GraduationYear = 2015, DegreeofGraduation="Lisans" },
new Education { SchoolName = "Ankara Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Özel Eğitim", StartYear = 2013, GraduationYear = 2017, DegreeofGraduation="Lisans" },
new Education { SchoolName = "Pamukkale Üniversitesi", FacultyName = "Sağlık Bilimleri Fakültesi", DepartmentName = "Fizyoterapi ve Rehabilitasyon", StartYear = 2012, GraduationYear = 2016, DegreeofGraduation="Lisans" },
new Education { SchoolName = "İstanbul Üniversitesi", FacultyName = "Cerrahpaşa Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2010, GraduationYear = 2014, DegreeofGraduation="Lisans" },
new Education { SchoolName = "Ege Üniversitesi", FacultyName = "Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2011, GraduationYear = 2015, DegreeofGraduation="Lisans" },
            };
            modelBuilder.Entity<Education>().HasData(educations);

            #endregion
        }
    }
}
