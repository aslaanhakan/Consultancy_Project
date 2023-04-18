using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Data;

namespace Consultancy_Project.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class AdministratorController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private IImageService _imageService;

        public AdministratorController(UserManager<User> userManager, RoleManager<Role> roleManager, IImageService imageService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _imageService = imageService;
        }

        public async Task<IActionResult> Index()
        {
            var admin = await _userManager.GetUsersInRoleAsync("Admin");
            List<AdminViewModel> adminWiew = admin.Select(a => new AdminViewModel
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                UserName = a.UserName,
            }).ToList();
            return View(adminWiew);
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var admin = await _userManager.Users.Where(x => x.Id == id).Include(x => x.Image).FirstOrDefaultAsync();
            AdminDetailsViewModel adminDetailsView = new AdminDetailsViewModel()
            {
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                Email = admin.Email,
                ImageUrl = admin.Image.Url,
                UserName = admin.UserName,
                Address = admin.Address,
                City = admin.City,
                CreatedTime = admin.CreatedTime,
                DateOfBirth = admin.DateOfBirth,
                Gender = admin.Gender,
                Phone = admin.PhoneNumber,
                UpdateTime = admin.UpdatedTime,
                EmailConfirmed = admin.EmailConfirmed,
                PhoneConfirmed= admin.PhoneNumberConfirmed
            };

            return View(adminDetailsView);
        }
        [HttpGet]

        public async Task<IActionResult> Edit(string id)
        {
            AdminUpdateViewModel adminUpdateViewModel = new AdminUpdateViewModel();
            return View(adminUpdateViewModel);
        }
    }
}
