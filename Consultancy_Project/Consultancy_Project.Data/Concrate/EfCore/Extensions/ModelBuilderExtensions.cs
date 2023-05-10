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
            #region WorkingHours
            List<WorkingHours> workingHours = new List<WorkingHours>()
            {
                new WorkingHours {Id=1, Hour="00:00-01:00" },
                new WorkingHours {Id=2, Hour="01:00-02:00" },
                new WorkingHours {Id=3, Hour="02:00-03:00" },
                new WorkingHours {Id=4, Hour="03:00-04:00" },
                new WorkingHours {Id=5, Hour="04:00-05:00" },
                new WorkingHours {Id=6, Hour="05:00-06:00" },
                new WorkingHours {Id=7, Hour="06:00-07:00" },
                new WorkingHours {Id=8, Hour="07:00-08:00" },
                new WorkingHours {Id=9, Hour="08:00-09:00" },
                new WorkingHours {Id=10, Hour="09:00-10:00" },
                new WorkingHours {Id=11, Hour="10:00-11:00" },
                new WorkingHours {Id=12, Hour="11:00-12:00" },
                new WorkingHours {Id=13, Hour="12:00-13:00" },
                new WorkingHours {Id=14, Hour="13:00-14:00" },
                new WorkingHours {Id=15, Hour="14:00-15:00" },
                new WorkingHours {Id=16, Hour="15:00-16:00" },
                new WorkingHours {Id=17, Hour="16:00-17:00" },
                new WorkingHours {Id=18, Hour="17:00-18:00" },
                new WorkingHours {Id=19, Hour="18:00-19:00" },
                new WorkingHours {Id=20, Hour="19:00-20:00" },
                new WorkingHours {Id=21, Hour="20:00-21:00" },
                new WorkingHours {Id=22, Hour="21:00-22:00" },
                new WorkingHours {Id=23, Hour="22:00-23:00" },
                new WorkingHours {Id=24, Hour="23:00-00:00" },

            };
            modelBuilder.Entity<WorkingHours>().HasData(workingHours);
            #endregion
          
            #region Users
            List<User> users = new List<User>
            {
            new User{FirstName="Hakan", LastName="Aslan", UserName="admin", NormalizedUserName="ADMIN", Email="admin@consultancy.com", NormalizedEmail="ADMIN.CONSULTANCY.COM", Gender="Erkek", DateOfBirth = new DateTime(1996,1,20), Address=" Özger Cad.No:6 Beşiktaş", City="İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed=true },

            new User{FirstName="Ayşe", LastName="Yılmaz", UserName="ayseyilmaz", NormalizedUserName="AYSEYILMAZ", Email="ayse.yilmaz@gmail.com", NormalizedEmail="AYSE.YILMAZ@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1992,3,14), Address="Cemal Gürsel Cd. No:5 Kadıköy", City="İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed=true },

            new User{FirstName="Mehmet", LastName="Özkan", UserName="mehmetozkan", NormalizedUserName="MEHMETOZKAN", Email="mehmet.ozkan@gmail.com", NormalizedEmail="MEHMET.OZKAN@GMAIL.COM", Gender="Erkek", DateOfBirth=new DateTime(1988,11,23), Address="Atatürk Cd. No:15/4 Çankaya", City="Ankara", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed=true },

            new User {FirstName="Zeynep", LastName="Güneş", UserName="zeynepgunes", NormalizedUserName="ZEYNEPGUNES", Email="zeynep.gunes@gmail.com", NormalizedEmail="ZEYNEP.GUNES@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1995,6,30), Address="Karşıyaka Cd. No:8/3 Alsancak", City="İzmir", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed=true},

            new User{FirstName="Ali", LastName="Demir", UserName="alidemir", NormalizedUserName="ALIDEMIR", Email="ali.demir@gmail.com", NormalizedEmail="ALI.DEMIR@GMAIL.COM", Gender="Erkek", DateOfBirth=new DateTime(1990,2,8), Address="Atatürk Mah. No:4 Bahçelievler", City="İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed=true },

            new User{FirstName="Gizem", LastName="Aydın", UserName="gizemaydin", NormalizedUserName="GIZEMAYDIN", Email="gizem.aydin@gmail.com", NormalizedEmail="GIZEM.AYDIN@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1987,9,18), Address="Mecidiyeköy Cd. No:23 Şişli", City="İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed=true },

            new User{FirstName="Can", LastName="Ergün", UserName="canergun", NormalizedUserName="CANERGUN", Email="can.ergun@gmail.com", NormalizedEmail="CAN.ERGUN@GMAIL.COM", Gender="Erkek", DateOfBirth=new DateTime(1993,12,10), Address="Turan Cd. No:7 Bornova", City="İzmir", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed=true },

            new User{FirstName = "Deniz", LastName = "Kartal", UserName = "deniz", NormalizedUserName = "DENIZ", Email = "deniz@asdasd.com", NormalizedEmail = "DENIZ@ASDASD.COM", Gender = "Kadın", DateOfBirth = new DateTime(1985, 5, 18), Address = "Halilpaşa Konağı Ap. No:18 Beşiktaş", City = "İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed = true},

            new User{FirstName = "Ali",LastName = "Yıldırım",UserName = "aliyildirim",NormalizedUserName = "ALIYILDIRIM",Email = "ali.yildirim@hotmail.com",NormalizedEmail = "ALI.YILDIRIM@HOTMAIL.COM",Gender = "Erkek",DateOfBirth = new DateTime(1992, 9, 5),Address = "Kuştepe Mah. Gümüşsuyu Cad. No:12 Şişli",City = "İstanbul",CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed = true},

            new User{FirstName = "Melis", LastName = "Öztürk", UserName = "melisozturk", NormalizedUserName = "MELISOZTURK", Email = "melis.ozturk@gmail.com", NormalizedEmail = "MELIS.OZTURK@GMAIL.COM", Gender = "Kadın", DateOfBirth = new DateTime(1988, 2, 14), Address = "Mecidiyeköy Mah. Dereboyu Cad. No:23 Şişli", City = "İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed = true},

            new User{FirstName = "Can", LastName = "Şahin", UserName = "cansahin", NormalizedUserName = "CANSAHIN", Email = "can.sahin@hotmail.com", NormalizedEmail = "CAN.SAHIN@HOTMAIL.COM", Gender = "Erkek", DateOfBirth = new DateTime(1995, 7, 22), Address = "Mecidiyeköy Mah. Vefa Cad. No:11 Şişli", City = "İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed = true},

            new User{FirstName = "Esra", LastName = "Avcı", UserName = "esraavci", NormalizedUserName = "ESRAAVCI", Email = "esra.avci@gmail.com", NormalizedEmail = "ESRA.AVCI@GMAIL.COM", Gender = "Kadın", DateOfBirth = new DateTime(1983, 11, 3), Address = "Etiler Mah. Bebek Cad. No:17 Beşiktaş", City = "İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed = true},

            new User{FirstName="Fatma", LastName="Kara", UserName="fatmakara", NormalizedUserName="FATMAKARA", Email="fatma.kara@gmail.com", NormalizedEmail="FATMA.KARA@GMAIL.COM", Gender="Kadın", DateOfBirth=new DateTime(1997,8,2), Address="İnönü Cd. No:12/1 Kartal", City="İstanbul", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, EmailConfirmed = true }
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
            new Specialization {Id=1, Name = "Depresyon", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Depresyon belirtileri gösteren kişilere destek olmak ve tedavi sürecinde yardımcı olmak."  },
            new Specialization {Id=2, Name = "Kaygı Bozukluğu", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Kaygı bozukluğu yaşayan bireylere destek olmak ve kaygı düzeylerini azaltmak için terapi yöntemleri uygulamak." },
            new Specialization {Id=3, Name = "Bağımlılık", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Bağımlılık sorunu yaşayan kişilere destek sağlamak ve bağımlılıktan kurtulmalarına yardımcı olmak için tedavi yöntemleri uygulamak." },
            new Specialization {Id=4, Name = "Öfke Kontrolü", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Öfke kontrolü sorunu yaşayan bireylere destek vermek ve öfke yönetimi becerilerini geliştirmelerine yardımcı olmak." },
            new Specialization {Id=5, Name = "Aile Terapisi", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Aile içi ilişkilerde yaşanan sorunlara destek sağlamak ve aile üyelerinin birbirleriyle iletişimini iyileştirmek için terapi yöntemleri uygulamak." },
            new Specialization {Id=6, Name = "Stres Yönetimi", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Stresli durumlarla başa çıkmada zorlanan bireylere destek vermek ve stres yönetimi becerilerini geliştirmelerine yardımcı olmak." },
            new Specialization {Id=7, Name = "Kişisel Gelişim", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Bireylerin kendilerini daha iyi tanımalarına ve kişisel gelişimlerine destek olmak için terapi yöntemleri uygulamak." },
            new Specialization {Id=8, Name = "Cinsel Sorunlar", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Cinsel sorunlar yaşayan bireylere destek sağlamak ve cinsel işlev bozukluklarıyla başa çıkmalarına yardımcı olmak için tedavi yöntemleri uygulamak." },
            new Specialization {Id = 9, Name = "Çift Terapisi", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Çiftler arasındaki sorunlara destek vermek ve ilişkilerini iyileştirmelerine yardımcı olmak için terapi yöntemleri uygulamak."},
            new Specialization {Id = 10, Name = "Travma Sonrası Stres Bozukluğu", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Travmatik bir olay sonrasında yaşanan stres ve kaygıya destek sağlamak ve travma sonrası stres bozukluğu tedavisi için yöntemler uygulamak."},
            new Specialization {Id = 11, Name = "Yeme Bozuklukları", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Description = "Yeme bozukluğu yaşayan bireylere destek vermek ve yeme bozukluğu tedavisi için terapi yöntemleri uygulamak."}};
            modelBuilder.Entity<Specialization>().HasData(specializations);

            #endregion

            #region Customer
            List<Customer> customers = new List<Customer> {
               new Customer {Id=1, UserId=users[8].Id  },
               new Customer {Id=2,  UserId=users[9].Id  },
               new Customer {Id=3,  UserId=users[10].Id },
               new Customer {Id=4,  UserId=users[11].Id },
               new Customer {Id=5,  UserId=users[12].Id },
            };
            modelBuilder.Entity<Customer>().HasData(customers);
            #endregion

            #region Consultant
            List<Consultant> consultants = new List<Consultant>
            {
                new Consultant {Id=1,UserId=users[1].Id, Promotion="Zorlu yaşam deneyimlerinizle baş etmenizde size destek olmak için burada. Kendinizi daha iyi hissetmek ve hayatınızda olumlu değişiklikler yapmak için birlikte çalışabiliriz.",  VisitsPrice = 250, JobTitle="Psikolojik Danışman", Confirmation=true },
                new Consultant {Id=2,UserId=users[2].Id, Promotion="Yıllardır psikolojik danışmanlık yapıyorum ve kişisel gelişim ve ruh sağlığı konularında uzmanım. Size uygun terapi yöntemleri kullanarak hayatınızı daha mutlu ve sağlıklı hale getirmek için buradayım.", VisitsPrice = 100, JobTitle="Klinik Psikolog", Confirmation=true},
                new Consultant {Id=3,UserId=users[3].Id, Promotion="Hayatınızdaki stresi, kaygıyı ve depresyonu azaltmanıza yardımcı olmak için burada. Kendinize ve yaşam kalitenize yatırım yapmak istiyorsanız, size destek olabilirim.", VisitsPrice = 100 ,  JobTitle="Psikolog", Confirmation = true},
                new Consultant {Id=4,UserId=users[4].Id, Promotion="Psikolojik danışmanlıkta uzmanım ve çift terapisi konusunda özellikle deneyimliyim. İlişkilerinizde sorun yaşıyorsanız, size yardımcı olmak için buradayım.", VisitsPrice = 100, JobTitle="Psikolojik Danışman", Confirmation = true},
                new Consultant {Id=5,UserId=users[5].Id, Promotion="Herhangi bir sorununuzda size yardımcı olmak için burada. Kişisel gelişim, özsaygı, aile ilişkileri ve daha birçok konuda size destek olabilirim.", VisitsPrice = 100 , JobTitle="Psikolojik Danışman", Confirmation = true},
                new Consultant {Id=6,UserId=users[6].Id, Promotion="Çocukluk travmaları, kayıp ve yas gibi konularda danışmanlık yapmaktayım. Kendinizi daha iyi hissetmeniz ve zihinsel sağlığınızı korumanız için size yardımcı olabilirim.", VisitsPrice = 100 , JobTitle="Psikolojik Danışman", Confirmation = true},
                new Consultant {Id=7,UserId=users[7].Id, Promotion="Stres yönetimi, öfke kontrolü ve bağımlılıkla mücadele konularında deneyimliyim. Kendinizi daha iyi hissetmek ve olumlu değişiklikler yapmak için size yardımcı olabilirim.", VisitsPrice = 100, JobTitle="Psikolojik Danışman", Confirmation = true}
            };
            modelBuilder.Entity<Consultant>().HasData(consultants);
            #endregion

            #region Available
            List<Available> availables = new List<Available>()
            {
                new Available {Id=1, Date=new DateOnly(2023, 5, 15), ConsultantId=consultants[0].Id, CreatedTime= DateTime.Now, UpdatedTime=DateTime.Now, WorkingHoursId=15 },
                new Available {Id=2, Date=new DateOnly(2023, 5, 16), ConsultantId=consultants[0].Id, CreatedTime= DateTime.Now, UpdatedTime=DateTime.Now, WorkingHoursId=20 },
                new Available {Id=3, Date=new DateOnly(2023, 5, 17), ConsultantId=consultants[0].Id, CreatedTime= DateTime.Now, UpdatedTime=DateTime.Now, WorkingHoursId=16 },
                new Available {Id=4, Date=new DateOnly(2023, 5, 22), ConsultantId=consultants[0].Id, CreatedTime= DateTime.Now, UpdatedTime=DateTime.Now, WorkingHoursId=13 },
                new Available {Id=5, Date=new DateOnly(2023, 5, 22), ConsultantId=consultants[0].Id, CreatedTime= DateTime.Now, UpdatedTime=DateTime.Now, WorkingHoursId=14 },
                new Available {Id=6, Date=new DateOnly(2023, 5, 22), ConsultantId=consultants[0].Id, CreatedTime= DateTime.Now, UpdatedTime=DateTime.Now, WorkingHoursId=15 }
            };
            modelBuilder.Entity<Available>().HasData(availables);
            #endregion

            #region Appointment
            List<Appointment> appointments = new List<Appointment>()
            {
                new Appointment {Id=1, AppointmentDate=new DateOnly(2023, 1, 1),ConsultantId=1,CustomerId=customers[0].Id, CreatedTime= DateTime.Now,UpdatedTime=DateTime.Now,AppointmentTime="10:00-11:00" , AppointmentState=AppointmentState.Successful,Price=200},
                new Appointment {Id=2, AppointmentDate=new DateOnly(2023, 1, 1),ConsultantId=1,CustomerId=customers[1].Id, CreatedTime= DateTime.Now,UpdatedTime=DateTime.Now,AppointmentTime="13:00-14:00", AppointmentState=AppointmentState.Unsuccessful,Price= 200},
                new Appointment {Id=3, AppointmentDate=new DateOnly(2023, 5, 20),ConsultantId=2,CustomerId=customers[2].Id, CreatedTime= DateTime.Now,UpdatedTime=DateTime.Now,AppointmentTime="15:00-16:00", AppointmentState=AppointmentState.Waiting},
                new Appointment {Id=4, AppointmentDate=new DateOnly(2023, 5, 25),ConsultantId=2,CustomerId=customers[3].Id, CreatedTime= DateTime.Now,UpdatedTime=DateTime.Now,AppointmentTime="18:00-19:00", AppointmentState=AppointmentState.Cancellation},
            };
            modelBuilder.Entity<Appointment>().HasData(appointments);
            #endregion

            #region Educations
            List<Education> educations = new List<Education>()
            {
                new Education {Id=1, SchoolName = "Anadolu Üniversitesi", FacultyName = "İktisadi ve İdari Bilimler Fakültesi", DepartmentName = "Psikolojik Danışmanlık ve Rehberlik", StartYear = 2009, GraduationYear = 2013, DegreeofGraduation="Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=1 },
                new Education {Id=2, SchoolName = "Hacettepe Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2013, GraduationYear = 2015, DegreeofGraduation="Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=2  },
                new Education {Id=3, SchoolName = "Dokuz Eylül Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2012, GraduationYear = 2016, DegreeofGraduation="Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=3  },
                new Education {Id=4, SchoolName = "Gazi Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Psikolojik Danışmanlık ve Rehberlik", StartYear = 2013, GraduationYear = 2017, DegreeofGraduation="Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=4  },
                new Education {Id=5, SchoolName = "Marmara Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Rehberlik ve Psikolojik Danışmanlık", StartYear = 2014, GraduationYear = 2018, DegreeofGraduation="Lisans" , CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=5 },
                new Education {Id=6, SchoolName = "Gazi Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Özel Eğitim", StartYear = 2011, GraduationYear = 2015, DegreeofGraduation="Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=6  },
                new Education {Id=7, SchoolName = "Ankara Üniversitesi", FacultyName = "Eğitim Bilimleri Fakültesi", DepartmentName = "Özel Eğitim", StartYear = 2013, GraduationYear = 2017, DegreeofGraduation="Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=7  },
                new Education {Id=8, SchoolName = "İstanbul Üniversitesi", FacultyName = "Cerrahpaşa Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2013, GraduationYear = 2015, DegreeofGraduation="Yüksek Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=1  },
                new Education {Id=9, SchoolName = "Ege Üniversitesi", FacultyName = "Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2016, GraduationYear = 2018, DegreeofGraduation="Yüksek Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=3  },
                new Education {Id=10, SchoolName = "Ege Üniversitesi", FacultyName = "Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2017, GraduationYear = 2019, DegreeofGraduation="Yüksek Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=7 },
                new Education {Id=11, SchoolName = "Ege Üniversitesi", FacultyName = "Tıp Fakültesi", DepartmentName = "Psikiyatri", StartYear = 2018, GraduationYear = 2020, DegreeofGraduation="Yüksek Lisans", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=5  },
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
               new Certificate {Id=1, CertificateName = "Psikolojik Danışmanlık Sertifikası", Institution = "Amerikan Psikoloji Derneği", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=1,CertificateTime=2015 },
               new Certificate {Id=2, CertificateName = "Psikologlar için Uzmanlık Sertifikası", Institution = "Amerikan Psikoloji Derneği (APA)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=2,CertificateTime=2015 },
               new Certificate {Id=3, CertificateName = "Sertifikalı Klinik Zihinsel Sağlık Danışmanı", Institution = "Ulusal Psikoloji Sertifikasyon Kurulu (National Board for Certified Counselors, NBCC)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=3,CertificateTime=2015 },
               new Certificate {Id=4, CertificateName = "Avrupa Psikolog (EuroPsy) Sertifikası", Institution = "Avrupa Psikoloji Federasyonu (European Federation of Psychologists' Associations, EFPA)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=4 ,CertificateTime=2015},
               new Certificate {Id=11, CertificateName = "Kognitif Davranış Terapisi (KDT) Sertifikası", Institution = "İngiliz Psikoloji Derneği (British Psychological Society, BPS)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=5 , CertificateTime = 2015},
                new Certificate {Id=5, CertificateName = "Psikologlar için Özel Uzmanlık Sertifikası", Institution = "Kanada Psikologlar Derneği (Canadian Psychological Association, CPA)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=6   ,CertificateTime=2015 },
                new Certificate {Id=6, CertificateName = "Psikodrama Uzmanlık Sertifikası", Institution = "Ulusal Psikodrama Derneği (National Psychodrama Association, NPA)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=1,CertificateTime=2015 },
                new Certificate {Id=7, CertificateName = "Sanat Terapisi Sertifikası", Institution = "Amerikan Sanat Terapisi Derneği (American Art Therapy Association, AATA)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=2,CertificateTime=2015 },
                new Certificate {Id=8, CertificateName = "Hipnoterapi Sertifikası", Institution = "Hipnoz ve Hipnoterapi Derneği (Hypnosis and Hypnotherapy Association, HHA)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=2,CertificateTime=2015 },
                new Certificate {Id=9, CertificateName = "Oyun Terapisi Sertifikası", Institution = "Oyun Terapisi Derneği (Association for Play Therapy, APT)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=6,CertificateTime=2015 },
                new Certificate {Id=10, CertificateName = "Çift ve Aile Terapisi Sertifikası", Institution = "Aile ve Çift Terapisi Derneği (American Association for Marriage and Family Therapy, AAMFT)", CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, ConsultantId=7,CertificateTime=2015 }
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
                new Image { Id = 1, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "1.jpg", UserId =users[0].Id },
                new Image { Id = 2, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "2.jpg", UserId =users[1].Id },
                new Image { Id = 3, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "3.jpg", UserId =users[2].Id },
                new Image { Id = 4, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "4.jpg", UserId =users[3].Id },
                new Image { Id = 5, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "5.jpg", UserId = users[4].Id },
                new Image { Id = 6, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "6.jpg", UserId = users[5].Id },
                new Image { Id = 7, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "7.jpg", UserId = users[6].Id },
                new Image { Id = 8, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "8.jpg", UserId = users[7].Id },
                new Image { Id = 9, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "9.jpg", UserId = users[8].Id },
                new Image { Id = 10, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "10.jpg", UserId = users[9].Id },
                new Image { Id = 11, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "11.jpg", UserId = users[10].Id },
                new Image { Id = 12, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "12.jpg", UserId = users[11].Id },
                new Image { Id = 13, CreatedTime = DateTime.Now, UpdatedTime = DateTime.Now, Url = "13.jpg", UserId = users[12].Id }
            };
            modelBuilder.Entity<Image>().HasData(images);
            #endregion

            #region Password
            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[2].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[3].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[4].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[5].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[6].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[7].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[8].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[9].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[10].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[11].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[12].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");

            #endregion
        }
    }
}
