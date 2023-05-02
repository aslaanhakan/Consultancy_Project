using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Core;
using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Data;
using System.Transactions;

namespace Consultancy_Project.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ConsultantController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private IImageService _imageService;
        private IConsultantService _consultantService;
        private ISpecializationService _specializationService;
        private ICertificateService _certificateService;
        private IEducationService _educationService;
        private ICustomerService _customerService;

        public ConsultantController(UserManager<User> userManager, RoleManager<Role> roleManager, IImageService imageService, IConsultantService consultantService, ISpecializationService specializationService, ICertificateService certificateService, IEducationService educationService, ICustomerService customerService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _imageService = imageService;
            _consultantService = consultantService;
            _specializationService = specializationService;
            _certificateService = certificateService;
            _educationService = educationService;
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var consultant = await _userManager.Users.Where(x => x.Consultant != null).Include(x => x.Consultant).ToListAsync();
            List<ConsultantViewModel> consultantWiew = consultant.Select(c => new ConsultantViewModel
            {
                ConsultantId = c.Consultant.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                UserName = c.UserName,
            }).ToList();
            return View(consultantWiew);
        }
        public async Task<IActionResult> Details(int id)
        {
            var user = await _userManager.Users.Include(x=>x.Image).ToListAsync();
            var consultant = await _consultantService.GetConsultantFullDataByIdAsync(id);
            ConsultantDetailsViewModel consultantDetailsView = new ConsultantDetailsViewModel()
            {
                FirstName = consultant.User.FirstName,
                LastName = consultant.User.LastName,
                Email = consultant.User.Email,
                ImageUrl = consultant.User.Image.Url,
                UserName = consultant.User.UserName,
                Address = consultant.User.Address,
                City = consultant.User.City,
                CreatedTime = consultant.User.CreatedTime,
                DateOfBirth = consultant.User.DateOfBirth,
                Gender = consultant.User.Gender,
                Phone = consultant.User.PhoneNumber,
                UpdateTime = consultant.User.UpdatedTime,
                EmailConfirmed = consultant.User.EmailConfirmed,
                PhoneConfirmed = consultant.User.PhoneNumberConfirmed,
                Promotion = consultant.User.Consultant.Promotion,
                Certificates = consultant.Certificates.Select(x => new Certificate
                {
                    Id = x.Id,
                    CertificateName = x.CertificateName,
                    CertificateTime = x.CertificateTime,
                    Institution = x.Institution,
                }).ToList(),
                Educations = consultant.Educations.Select(x => new Education
                {
                    Id = x.Id,
                    DegreeofGraduation = x.DegreeofGraduation,
                    DepartmentName = x.DepartmentName,
                    FacultyName = x.FacultyName,
                    GraduationYear = x.GraduationYear,
                    SchoolName = x.SchoolName,
                    StartYear = x.StartYear,
                }).ToList(),
                JobTitle = consultant.JobTitle,
                Specializations = consultant.ConsultantsSpecializations.Select(x => new Specialization
                {
                    Id=x.SpecializationId,
                    Name=x.Specialization.Name,
                    Description=x.Specialization.Description
                }).ToList(),
                VisitsPrice = consultant.VisitsPrice

            };

            return View(consultantDetailsView);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var specializations = await _specializationService.GetAllAsync();
            var user = await _userManager.Users.Include(x => x.Image).ToListAsync();
            var consultant = await _consultantService.GetConsultantFullDataByIdAsync(id);
            ConsultantUpdateViewModel consultantUpdateView = new ConsultantUpdateViewModel()
            {
                ConsultantId=consultant.Id,
                FirstName = consultant.User.FirstName,
                LastName = consultant.User.LastName,
                Email = consultant.User.Email,
                ImageUrl = consultant.User.Image.Url,
                UserName = consultant.User.UserName,
                Address = consultant.User.Address,
                City = consultant.User.City,
                CreatedTime = consultant.User.CreatedTime,
                DateOfBirth = consultant.User.DateOfBirth,
                Gender = consultant.User.Gender,
                Phone = consultant.User.PhoneNumber,
                UpdateTime = consultant.User.UpdatedTime,
                EmailConfirmed = consultant.User.EmailConfirmed,
                PhoneConfirmed = consultant.User.PhoneNumberConfirmed,
                Promotion = consultant.User.Consultant.Promotion,
                Certificates = consultant.Certificates.Select(x => new Certificate
                {
                    Id = x.Id,
                    CertificateName = x.CertificateName,
                    CertificateTime = x.CertificateTime,
                    Institution = x.Institution,
                }).ToList(),
                Educations = consultant.Educations.Select(x => new Education
                {
                    Id = x.Id,
                    DegreeofGraduation = x.DegreeofGraduation,
                    DepartmentName = x.DepartmentName,
                    FacultyName = x.FacultyName,
                    GraduationYear = x.GraduationYear,
                    SchoolName = x.SchoolName,
                    StartYear = x.StartYear,
                }).ToList(),
                JobTitle = consultant.JobTitle,
                Specializations = consultant.ConsultantsSpecializations.Select(x => new Specialization
                {
                    Id = x.SpecializationId,
                    Name = x.Specialization.Name,
                    Description = x.Specialization.Description
                }).ToList(),
                VisitsPrice = consultant.VisitsPrice

            };
            var specialization = consultantUpdateView.Specializations;
            var nonSpecialization = new List<Specialization>();
            foreach (var specializ in specializations)
            {

                if ( !specialization.Any(x=> x.Id==specializ.Id))
                {
                    nonSpecialization.Add(specializ);
                }                

            }
            consultantUpdateView.NonSpecialization=nonSpecialization;

            return View(consultantUpdateView);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ConsultantUpdateViewModel consultantUpdateView)
        {

            if (ModelState.IsValid)
            {
                var consultant = await _consultantService.GetConsultantFullDataByIdAsync(consultantUpdateView.ConsultantId);

                consultant.User.FirstName = consultantUpdateView.FirstName;
                consultant.User.LastName = consultantUpdateView.LastName;
                consultant.User.Email = consultantUpdateView.Email;
                consultant.User.Address = consultantUpdateView.Address;
                consultant.User.City = consultantUpdateView.City;
                consultant.User.DateOfBirth = consultantUpdateView.DateOfBirth;
                consultant.User.Gender = consultantUpdateView.Gender;
                consultant.User.PhoneNumber = consultantUpdateView.Phone;
                consultant.User.UpdatedTime = DateTime.Now;
                consultant.User.EmailConfirmed = consultantUpdateView.EmailConfirmed;
                consultant.User.PhoneNumberConfirmed = consultantUpdateView.PhoneConfirmed;
                consultant.VisitsPrice=consultantUpdateView.VisitsPrice;
                consultant.JobTitle=consultantUpdateView.JobTitle;
                consultant.Promotion=consultantUpdateView.Promotion;
                if (consultantUpdateView.ImageFile != null)
                {
                    var image = new Image
                    {
                        CreatedTime = DateTime.Now,
                        UpdatedTime = DateTime.Now,
                        Url = Jobs.UploadImage(consultantUpdateView.ImageFile),
                        //UserId = consultantUpdateView.ConsultantId
                    };

                    await _imageService.CreateAsync(image);

                }
                _consultantService.UpdateConsultantData(consultant);
                var result = await _userManager.UpdateAsync(consultant.User);
                return RedirectToAction("Index");

            }
            return View(consultantUpdateView);

        }
        public async Task<IActionResult> Remove(int id)
        {
            var consultant = await _consultantService.GetByIdAsync(id);
            User user = await _userManager.FindByIdAsync(consultant.UserId);
            _consultantService.Delete(consultant);
            
            var resultRemove = await _userManager.RemoveFromRoleAsync(user, "Consultant");
            if (!resultRemove.Succeeded)
            {
                foreach (var error in resultRemove.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            var resultAdd = await _userManager.AddToRoleAsync(user, "Customer");
            var customer = new Customer
            {
                UserId = user.Id,
                

            };
            _customerService.CreateAsync(customer);
            if (!resultAdd.Succeeded)
            {
                foreach (var error in resultAdd.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return RedirectToAction("Index");
        }
            [HttpPost]

        public async Task<IActionResult> EditSpecialization(SpecializationEditViewModel specializationEditViewModel)
        {
            _specializationService.EditSpecializationsConsultantAsync(specializationEditViewModel.IdsToAddSpecialization,specializationEditViewModel.IdsToRemoveSpecialization, specializationEditViewModel.ConsultantId);
            return RedirectToAction("Edit", new { id = specializationEditViewModel.ConsultantId });
        }
        [HttpPost]
        public async Task<IActionResult> AddEducation(Education education)
        {
            education.CreatedTime= DateTime.Now;
            education.UpdatedTime = DateTime.Now;
            await _educationService.CreateAsync(education);
            return RedirectToAction("Edit", new { id = education.ConsultantId });
        }
        
        public async Task<IActionResult> DeleteEducation(int id)
        {
            var education = await _educationService.GetByIdAsync(id);
            if (education != null)
            {
                _educationService.Delete(education);
                return RedirectToAction("Edit", new { id = education.ConsultantId });

            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> AddCertificate(Certificate certificate)
        {
            certificate.CreatedTime = DateTime.Now;
            certificate.UpdatedTime = DateTime.Now;
            await _certificateService.CreateAsync(certificate);
            return RedirectToAction("Edit", new { id = certificate.ConsultantId });
        }
        public async Task<IActionResult> DeleteCertificate(int id)
        {
            var certificate = await _certificateService.GetByIdAsync(id);
            if (certificate != null)
            {
                _certificateService.Delete(certificate);
                return RedirectToAction("Edit", new { id = certificate.ConsultantId });

            }
            return RedirectToAction("Index");

        }
    }
}
// Gerekli Durumlarda kullanacağım
//List<User> consultant = await _userManager.Users.Where(x => x.Consultant != null).Include(x => x.Consultant).ToListAsync();
