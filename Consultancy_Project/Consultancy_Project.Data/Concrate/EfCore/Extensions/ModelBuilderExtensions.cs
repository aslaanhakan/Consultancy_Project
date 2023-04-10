using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Concrate.EfCore.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Users
            List<User> users = new List<User>
            {
                 new User{FirstName="Hakan",
                    LastName="Aslan",
                    UserName="admin",
                    NormalizedUserName="ADMIN",
                    Email="admin@consultancy.com",
                    NormalizedEmail="ADMIN.CONSULTANCY.COM",
                    Gender="Erkek",
                    DateOfBirth=new DateTime(1996,1,20),
                    Address=" Özger Cad.No:6 Beşiktaş",
                    City="İstanbul",
                    EmailConfirmed=true },

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

new User {FirstName="Zeynep", LastName="Güneş", UserName="zeynepgunes", NormalizedUserName="ZEYNEPGUNES", Email="zeynep.gunes@gmail.com", NormalizedEmail="ZEYNEP.GUNES@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1995,6,30), Address="Karşıyaka Cd. No:8/3 Alsancak", City="İzmir", EmailConfirmed=true},

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
},
                new User{FirstName="Fatma", LastName="Kara", UserName="fatmakara", NormalizedUserName="FATMAKARA", Email="fatma.kara@gmail.com", NormalizedEmail="FATMA.KARA@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1997,8,2), Address="İnönü Cd. No:12/1 Kartal", City="İstanbul",EmailConfirmed = true }
            };
            modelBuilder.Entity<User>().HasData(users);

            #endregion

            #region Role
            List<Role> roles = new List<Role>
            {
                new Role{Name="Admin", Description="Yönetici", NormalizedName="ADMIN"},
                new Role{Name="Customer", Description="Kullanıcı", NormalizedName="CUSTOMER"},
                new Role{Name="Consultant", Description="Danışanman", NormalizedName="CONSULTANT"},

            };
            modelBuilder.Entity<Role>().HasData(roles);

            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>{ UserId=users[0].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Admin").Id},
                new IdentityUserRole<string>{ UserId=users[1].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Consultant").Id},
                new IdentityUserRole<string>{ UserId=users[2].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Consultant").Id},
                new IdentityUserRole<string>{ UserId=users[3].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Consultant").Id},
                new IdentityUserRole<string>{ UserId=users[4].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Consultant").Id},
                new IdentityUserRole<string>{ UserId=users[5].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Consultant").Id},
                new IdentityUserRole<string>{ UserId=users[6].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Consultant").Id},
                new IdentityUserRole<string>{ UserId=users[7].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Consultant").Id},
                new IdentityUserRole<string>{ UserId=users[8].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Customer").Id},
                new IdentityUserRole<string>{ UserId=users[9].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Customer").Id},
                new IdentityUserRole<string>{ UserId=users[10].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Customer").Id},
                new IdentityUserRole<string>{ UserId=users[11].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Customer").Id},
                new IdentityUserRole<string>{ UserId=users[12].Id, RoleId=roles.FirstOrDefault(r=>r.Name=="Customer").Id},
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

            #region Specializations
            List<Specialization> specializations = new List<Specialization>()
            {  
            new Specialization {Id=1, Name = "Depresyon", Description = "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak." },
            new Specialization {Id=2, Name = "Kaygı Bozukluğu", Description = "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak." },
            new Specialization {Id=3, Name = "Bağımlılık", Description = "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak." },
            new Specialization {Id=4, Name = "Öfke Kontrolü", Description = "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak." },
            new Specialization {Id=5, Name = "Aile Terapisi", Description = "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak." },
            new Specialization {Id=6, Name = "Stres Yönetimi", Description = "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak." },
            new Specialization {Id=7, Name = "Kişisel Gelişim", Description = "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak." },
            new Specialization {Id=8, Name = "Cinsel Sorunlar", Description = "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak." },
            new Specialization {Id=9, Name = "Çift Terapisi", Description = "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak." },
            new Specialization {Id=10, Name = "Travma Sonrası Stres Bozukluğu", Description = "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak." },
            new Specialization {Id=11, Name = "Yeme Bozuklukları", Description = "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak." }};
            modelBuilder.Entity<Specialization>().HasData(specializations);

            #endregion

            #region Customer
            List<Customer> customers = new List<Customer> {
               new Customer {Id=1, UserId=users[8].Id,  },
               new Customer {Id=2, UserId=users[9].Id,  },
               new Customer {Id=3, UserId=users[10].Id, },
               new Customer {Id=4, UserId=users[11].Id, },
               new Customer {Id=5, UserId=users[12].Id, },
            };
            modelBuilder.Entity<Customer>().HasData(customers);
            #endregion

            #region Consultant
            List<Consultant> consultants = new List<Consultant>
            {
                new Consultant {Id=1,UserId=users[1].Id, Promotion="Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.", VisitsPrice = 100,JobTitle="Psikolojik Danışman"},
                new Consultant {Id=2,UserId=users[2].Id, Promotion="Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", VisitsPrice = 100,JobTitle="Klinik Psikolog"},
                new Consultant {Id=3,UserId=users[3].Id, Promotion="Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", VisitsPrice = 100,JobTitle="Psikolog"},
                new Consultant {Id=4,UserId=users[4].Id, Promotion="Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", VisitsPrice = 100,JobTitle="Psikolojik Danışman"},
                new Consultant {Id=5,UserId=users[5].Id, Promotion="Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", VisitsPrice = 100,JobTitle="Psikolojik Danışman"},
                new Consultant {Id=6,UserId=users[6].Id, Promotion="Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", VisitsPrice = 100,JobTitle="Psikolojik Danışman"},
                new Consultant {Id=7,UserId=users[0].Id, Promotion="Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", VisitsPrice = 100,JobTitle="Psikolojik Danışman"}
            };
            modelBuilder.Entity<Consultant>().HasData(consultants);
            #endregion


            #region Educations
            List<Education> educations = new List<Education>()
            {
                new Education {Id=1, SchoolName = "Anadolu Üniversitesi", FacultyName = "İktisadi ve İdari Bilimler Fakültesi", DepartmentName = "Psikolojik Danışmanlık ve Rehberlik", StartYear = 2009, GraduationYear = 2013, DegreeofGraduation="Lisans",ConsultantId=1 },
                new Education {Id=2, SchoolName = "Hacettepe Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2013, GraduationYear = 2015, DegreeofGraduation="Lisans",ConsultantId=2  },
                new Education {Id=3, SchoolName = "Dokuz Eylül Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2012, GraduationYear = 2016, DegreeofGraduation="Lisans",ConsultantId=3  },
                new Education {Id=4, SchoolName = "Gazi Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Psikolojik Danışmanlık ve Rehberlik", StartYear = 2013, GraduationYear = 2017, DegreeofGraduation="Lisans",ConsultantId=4  },
                new Education {Id=5, SchoolName = "Marmara Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2014, GraduationYear = 2018, DegreeofGraduation="Lisans" ,ConsultantId=5 },
                new Education {Id=6, SchoolName = "Gazi Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Özel Eğitim", StartYear = 2011, GraduationYear = 2015, DegreeofGraduation="Lisans",ConsultantId=6  },
                new Education {Id=7, SchoolName = "Ankara Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Özel Eğitim", StartYear = 2013, GraduationYear = 2017, DegreeofGraduation="Lisans",ConsultantId=7  },
                new Education {Id=8, SchoolName = "İstanbul Üniversitesi", FacultyName = "Cerrahpaşa Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2013, GraduationYear = 2015, DegreeofGraduation="Yüksek Lisans",ConsultantId=1  },
                new Education {Id=9, SchoolName = "Ege Üniversitesi", FacultyName = "Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2016, GraduationYear = 2018, DegreeofGraduation="Yüksek Lisans",ConsultantId=3  },
                new Education {Id=10, SchoolName = "Ege Üniversitesi", FacultyName = "Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2017, GraduationYear = 2019, DegreeofGraduation="Yüksek Lisans",ConsultantId=7 },
                new Education {Id=11, SchoolName = "Ege Üniversitesi", FacultyName = "Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2018, GraduationYear = 2020, DegreeofGraduation="Yüksek Lisans",ConsultantId=5  },
            };
            modelBuilder.Entity<Education>().HasData(educations);

            #endregion

            #region CustomersConsultants
            List<CustomersConsultans> customersConsultans = new List<CustomersConsultans> {
            new CustomersConsultans{      ConsultantId=consultants[0].Id, CustomerId=customers[0].Id  },
            new CustomersConsultans{      ConsultantId=consultants[2].Id, CustomerId=customers[1].Id  },
            new CustomersConsultans{      ConsultantId=consultants[1].Id, CustomerId=customers[2].Id  },
            new CustomersConsultans{      ConsultantId=consultants[3].Id, CustomerId=customers[3].Id  },
            new CustomersConsultans{      ConsultantId=consultants[4].Id, CustomerId=customers[4].Id  },
            new CustomersConsultans{      ConsultantId=consultants[6].Id, CustomerId=customers[3].Id  },
            };
            modelBuilder.Entity<CustomersConsultans>().HasData(customersConsultans);
            #endregion

            #region Certificates
            List<Certificate> certificates = new List<Certificate> {
               new Certificate {Id=1, CertificateName = "Psikolojik Danışmanlık Sertifikası", Institution = "Amerikan Psikoloji Derneği",ConsultantId=1,CertificateTime=2015 },
               new Certificate {Id=2, CertificateName = "Psikologlar için Uzmanlık Sertifikası", Institution = "Amerikan Psikoloji Derneği (APA)",ConsultantId=2,CertificateTime=2015 },
               new Certificate {Id=3, CertificateName = "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", Institution = "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)",ConsultantId=3,CertificateTime=2015 },
               new Certificate {Id=4, CertificateName = "Avrupa Psikolog (EuroPsy) Sertifikası", Institution = "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)",ConsultantId=4 ,CertificateTime=2015},
               new Certificate {Id=11, CertificateName = "Kognitif Davranış Terapisi (KDT) Sertifikası", Institution = "İngiliz Psikoloji Derneği (British Psychological Society, BPS)",ConsultantId=5 , CertificateTime = 2015},
                new Certificate {Id=5, CertificateName = "Psikologlar için Özel Uzmanlık Sertifikası", Institution = "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)",ConsultantId=6   ,CertificateTime=2015 },
                new Certificate {Id=6, CertificateName = "Psikodrama Uzmanlık Sertifikası", Institution = "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)",ConsultantId=1,CertificateTime=2015 },
                new Certificate {Id=7, CertificateName = "Sanat Terapisi Sertifikası", Institution = "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)",ConsultantId=2,CertificateTime=2015 },
                new Certificate {Id=8, CertificateName = "Hipnoterapi Sertifikası", Institution = "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)",ConsultantId=2,CertificateTime=2015 },
                new Certificate {Id=9, CertificateName = "Oyun Terapisi Sertifikası", Institution = "Oyun Terapisi Derneği (Association for Play Therapy, APT)",ConsultantId=6,CertificateTime=2015 },
                new Certificate {Id=10, CertificateName = "Çift ve Aile Terapisi Sertifikası", Institution = "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)",ConsultantId=7,CertificateTime=2015 }
            };
            modelBuilder.Entity<Certificate>().HasData(certificates);
            #endregion

            #region ConsultantsSpecializations

            List<ConsultantsSpecializations> consultantsSpecializations = new List<ConsultantsSpecializations> {
            new ConsultantsSpecializations{      ConsultantId=1, SpecializationId=1  },
            new ConsultantsSpecializations{      ConsultantId=1, SpecializationId=2  },
            new ConsultantsSpecializations{      ConsultantId=1, SpecializationId=3  },
            new ConsultantsSpecializations{      ConsultantId=1, SpecializationId=6  },
            new ConsultantsSpecializations{      ConsultantId=1, SpecializationId=7  },
            new ConsultantsSpecializations{      ConsultantId=1, SpecializationId=11  },
            new ConsultantsSpecializations{      ConsultantId=1, SpecializationId=9  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=1  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=2  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=3  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=4  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=5  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=6  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=7  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=8  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=10  },
            new ConsultantsSpecializations{      ConsultantId=2, SpecializationId=11  },
            new ConsultantsSpecializations{      ConsultantId=3, SpecializationId=2  },
            new ConsultantsSpecializations{      ConsultantId=3, SpecializationId=4  },
            new ConsultantsSpecializations{      ConsultantId=3, SpecializationId=8  },
            new ConsultantsSpecializations{      ConsultantId=3, SpecializationId=9  },
            new ConsultantsSpecializations{      ConsultantId=3, SpecializationId=10  },
            new ConsultantsSpecializations{      ConsultantId=3, SpecializationId=11  },
            new ConsultantsSpecializations{      ConsultantId=4, SpecializationId=1  },
            new ConsultantsSpecializations{      ConsultantId=4, SpecializationId=2  },
            new ConsultantsSpecializations{      ConsultantId=4, SpecializationId=4  },
            new ConsultantsSpecializations{      ConsultantId=4, SpecializationId=6  },
            new ConsultantsSpecializations{      ConsultantId=4, SpecializationId=7  },
            new ConsultantsSpecializations{      ConsultantId=4, SpecializationId=10  },
            new ConsultantsSpecializations{      ConsultantId=4, SpecializationId=11  },
            new ConsultantsSpecializations{      ConsultantId=5, SpecializationId=3  },
            new ConsultantsSpecializations{      ConsultantId=5, SpecializationId=4  },
            new ConsultantsSpecializations{      ConsultantId=5, SpecializationId=5  },
            new ConsultantsSpecializations{      ConsultantId=5, SpecializationId=6  },
            new ConsultantsSpecializations{      ConsultantId=5, SpecializationId=7 },
            new ConsultantsSpecializations{      ConsultantId=6, SpecializationId=1 },
            new ConsultantsSpecializations{      ConsultantId=6, SpecializationId=3 },
            new ConsultantsSpecializations{      ConsultantId=6, SpecializationId=5  },
            new ConsultantsSpecializations{      ConsultantId=6, SpecializationId=7  },
            new ConsultantsSpecializations{      ConsultantId=6, SpecializationId=9 },
            new ConsultantsSpecializations{      ConsultantId=6, SpecializationId=11  },
            new ConsultantsSpecializations{      ConsultantId=7, SpecializationId=1 },
            new ConsultantsSpecializations{      ConsultantId=7, SpecializationId=4  },
            new ConsultantsSpecializations{      ConsultantId=7, SpecializationId=7  },
            new ConsultantsSpecializations{      ConsultantId=7, SpecializationId=10 },

            };
            modelBuilder.Entity<ConsultantsSpecializations>().HasData(consultantsSpecializations);

            #endregion

            #region Image
            List<Image> images = new List<Image>()
            {
                new Image { Id = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "1.jpg", UserId =users[0].Id },
                new Image { Id = 2, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "2.jpg", UserId =users[1].Id },
                new Image { Id = 3, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "3.jpg", UserId =users[2].Id },
                new Image { Id = 4, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "4.jpg", UserId =users[3].Id },
                new Image { Id = 5, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "5.jpg", UserId = users[4].Id },
                new Image { Id = 6, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "6.jpg", UserId = users[5].Id },
                new Image { Id = 7, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "7.jpg", UserId = users[6].Id },
                new Image { Id = 8, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "8.jpg", UserId = users[7].Id },
                new Image { Id = 9, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "9.jpg", UserId = users[8].Id },
                new Image { Id = 10, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "10.jpg", UserId = users[9].Id },
                new Image { Id = 11, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "11.jpg", UserId = users[10].Id },
                new Image { Id = 12, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "12.jpg", UserId = users[11].Id },
                new Image { Id = 13, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Url = "13.jpg", UserId = users[12].Id }
            };
            modelBuilder.Entity<Image>().HasData(images);
            #endregion
        }
    }
}
