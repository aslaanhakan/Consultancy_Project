using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Core;
using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public ConsultantController(UserManager<User> userManager, RoleManager<Role> roleManager, IImageService imageService, IConsultantService consultantService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _imageService = imageService;
            _consultantService = consultantService;
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

        public async Task<IActionResult> Edit(string id)
        {

            var user = await _userManager.Users.Where(x => x.Id == id).Include(x => x.Image).FirstOrDefaultAsync();
            ConsultantUpdateViewModel consultantUpdateView = new ConsultantUpdateViewModel()
            {
                ConsultantId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                ImageUrl = user.Image.Url,
                UserName = user.UserName,
                Address = user.Address,
                City = user.City,
                CreatedTime = user.CreatedTime,
                DateOfBirth = user.DateOfBirth,
                Gender = user.Gender,
                Phone = user.PhoneNumber,
                UpdateTime = user.UpdatedTime,
                EmailConfirmed = user.EmailConfirmed,
                PhoneConfirmed = user.PhoneNumberConfirmed
            };

            return View(consultantUpdateView);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ConsultantUpdateViewModel consultantUpdateView)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.Users.Where(x => x.Id == consultantUpdateView.ConsultantId).Include(x => x.Image).FirstOrDefaultAsync();
                user.FirstName = consultantUpdateView.FirstName;
                user.LastName = consultantUpdateView.LastName;
                user.Email = consultantUpdateView.Email;
                user.Address = consultantUpdateView.Address;
                user.City = consultantUpdateView.City;
                user.DateOfBirth = consultantUpdateView.DateOfBirth;
                user.Gender = consultantUpdateView.Gender;
                user.PhoneNumber = consultantUpdateView.Phone;
                user.UpdatedTime = DateTime.Now;
                user.EmailConfirmed = consultantUpdateView.EmailConfirmed;
                user.PhoneNumberConfirmed = consultantUpdateView.PhoneConfirmed;
                if (consultantUpdateView.ImageFile != null)
                {
                    var image = new Image
                    {
                        CreatedTime = DateTime.Now,
                        UpdatedTime = DateTime.Now,
                        Url = Jobs.UploadImage(consultantUpdateView.ImageFile),
                        UserId = consultantUpdateView.ConsultantId
                    };

                    await _imageService.CreateAsync(image);

                }
                var result = await _userManager.UpdateAsync(user);
                return RedirectToAction("Index");

            }
            return View(consultantUpdateView);

        }
    }
}
// Gerekli Durumlarda kullanacağım
//List<User> consultant = await _userManager.Users.Where(x => x.Consultant != null).Include(x => x.Consultant).ToListAsync();
