using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Consultancy_Project.MVC.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class AdminNavbarViewComponent: ViewComponent
    {
        private UserManager<User> _userManager;

        public AdminNavbarViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var admin = await _userManager.GetUsersInRoleAsync("Admin");
            UserViewModel users = _userManager.Users.Where(x=>x.FirstName==admin.FirstOrDefault().FirstName).Select(u => new UserViewModel
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                ImageUrl = u.Images.Url
            }).FirstOrDefault();
           
            return View(users);
        }
    }
}
