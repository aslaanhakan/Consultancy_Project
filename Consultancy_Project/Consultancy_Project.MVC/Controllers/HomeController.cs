using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Consultancy_Project.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private IConsultantService _consultantService;

        public HomeController(IConsultantService consultantService, UserManager<User> userManager)
        {
            _consultantService = consultantService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _consultantService.GetAllAsync();
            var consultants = await _userManager.Users.Where(x=>x.Consultant!=null).Include(x=> x.Consultant).Include(x=>x.Image).ToListAsync();
            var homePageDatas = new HomePageViewModel()
            {
                Consultants = consultants,
            };
            return View(homePageDatas);
        }

       
    }
}