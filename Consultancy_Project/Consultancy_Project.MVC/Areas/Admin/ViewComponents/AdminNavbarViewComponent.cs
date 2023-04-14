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
            var admin = await _userManager.FindByNameAsync(User.Identity.Name);
            AdminViewModel adminView = _userManager.Users.Where(x=>x.Id==admin.Id).Select(u => new AdminViewModel
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                ImageUrl = u.Images.Url
            }).FirstOrDefault();
           
            return View(adminView);
        }
    }
}
