using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Consultancy_Project.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class AdministratorController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public AdministratorController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var admin = await _userManager.GetUsersInRoleAsync("Admin");
            List<AdminViewModel> adminWiew = admin.Select(a=>new AdminViewModel
            {
                Id=a.Id,
                FirstName= a.FirstName,
                LastName= a.LastName,
                Email=a.Email,
                UserName= a.UserName,
            }).ToList();
            return View(adminWiew);
        }
    }
}
