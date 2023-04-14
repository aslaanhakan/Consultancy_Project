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
    public class ConsultantController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public ConsultantController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var consultant = await _userManager.GetUsersInRoleAsync("Consultant");
            List<ConsultantViewModel> consultantWiew = consultant.Select(c => new ConsultantViewModel
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                UserName = c.UserName,
            }).ToList();
            return View(consultantWiew);
        }
    }
}
