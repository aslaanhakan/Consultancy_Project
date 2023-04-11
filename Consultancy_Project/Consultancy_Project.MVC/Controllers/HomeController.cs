using Consultancy_Project.Business.Abstract;
using Consultancy_Project.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Consultancy_Project.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IConsultantService _consultantService;

        public HomeController(IConsultantService consultantService)
        {
            _consultantService = consultantService;
        }

        public IActionResult Index()
        {

            return View();
        }

       
    }
}