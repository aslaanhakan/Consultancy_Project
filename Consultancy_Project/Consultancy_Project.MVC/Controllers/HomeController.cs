using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate;
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
        private ISpecializationService _specializationService;
        public HomeController(IConsultantService consultantService, UserManager<User> userManager, ISpecializationService specializationService)
        {
            _consultantService = consultantService;
            _userManager = userManager;
            _specializationService = specializationService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _consultantService.GetConsultantsFullDataAsync();
            var specializations = await _specializationService.GetAllAsync();

            var homePageDatas = new HomePageViewModel()
            {
                Consultants = result,     
                Specializations=specializations,
            };
            
            return View(homePageDatas);
        }

       
    }
}