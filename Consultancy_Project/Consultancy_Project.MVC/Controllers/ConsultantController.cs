using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Consultancy_Project.MVC.Controllers
{
    public class ConsultantController : Controller
    {
        private readonly UserManager<User> _userManager;
        private IConsultantService _consultantService;
        private ISpecializationService _specializationService;

        public ConsultantController(UserManager<User> userManager, IConsultantService consultantService, ISpecializationService specializationService)
        {
            _userManager = userManager;
            _consultantService = consultantService;
            _specializationService = specializationService;
        }

        public IActionResult Index()
        {
            return View();

        }
        public async Task<IActionResult> ConsultantDetails(int id)
        {
            var consultant = await _consultantService.GetConsultantFullDataByIdAsync(id);
            var consultantDetails = new ConsultantDetailsViewModel()
            {
                Id=consultant.Id,
                FirstName = consultant.User.FirstName,
                LastName = consultant.User.LastName,
                DateOfBirth = consultant.User.DateOfBirth,
                ImageUrl = consultant.User.Image.Url,
                UserName = consultant.User.UserName,
                Email = consultant.User.Email,
                Gender = consultant.User.Gender,
                Phone = consultant.User.PhoneNumber,
                EmailConfirmed = consultant.User.EmailConfirmed,
                PhoneConfirmed = consultant.User.PhoneNumberConfirmed,
                Address = consultant.User.Address,
                City = consultant.User.City,
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
                    GraduationYear= x.GraduationYear,
                    SchoolName = x.SchoolName,
                    StartYear = x.StartYear,
                    
                }).ToList(),
                Specializations = consultant.ConsultantsSpecializations.Select(x=> new Specialization
                {
                    Id=x.Specialization.Id,
                    Name=x.Specialization.Name,
                    Description=x.Specialization.Description,

                }).ToList(),
                JobTitle = consultant.JobTitle,
                VisitsPrice = consultant.VisitsPrice,
                Promotion= consultant.Promotion,
            };
            return View(consultantDetails);

        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var name = id;
            var specializations = await _specializationService.GetAllAsync();
            var user = await _userManager.Users.Where(x=>x.UserName == name).Include(x=>x.Consultant).FirstOrDefaultAsync();
            var consultant = await _consultantService.GetConsultantFullDataByIdAsync(user.Consultant.Id);
            ConsultantUpdateViewModel consultantUpdateView = new ConsultantUpdateViewModel()
            {
                ConsultantId = consultant.Id,
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

                if (!specialization.Any(x => x.Id == specializ.Id))
                {
                    nonSpecialization.Add(specializ);
                }

            }
            consultantUpdateView.NonSpecialization = nonSpecialization;

            return View(consultantUpdateView);
        }
    }
}
