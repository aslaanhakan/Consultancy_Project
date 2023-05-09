using Microsoft.AspNetCore.Mvc;

namespace Consultancy_Project.MVC.Controllers
{
    public class Appointment : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
