using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Consultancy_Project.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CustomerController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public CustomerController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var customer = await _userManager.GetUsersInRoleAsync("Customer");
            List<CustomerViewModel> customerWiew = customer.Select(a => new CustomerViewModel
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                UserName = a.UserName,
            }).ToList();
            return View(customerWiew);
        }
    }
}
