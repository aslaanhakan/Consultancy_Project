using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Consultancy_Project.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;

        public HomeController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<UserViewModel> users = _userManager.Users.Select(u=> new UserViewModel
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                ImageUrl=u.Images.Url
            }).ToList();
            return View(users);
        }
    }
}
