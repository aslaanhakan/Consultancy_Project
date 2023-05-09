using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Consultancy_Project.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private IAppointmentService _appointmentService;
        public HomeController(UserManager<User> userManager, IAppointmentService appointmentService)
        {
            _userManager = userManager;
            _appointmentService = appointmentService;
        }

        public async Task<IActionResult> Index()
        {
            var appointment = await _appointmentService.GetAllFullDataAsync();
            var appointmentViewModel = appointment.Select(x => new AppointmentViewModel
            {
                Id = x.Id,
                UserCustomer=x.Customer.User,
                UserConsultant=x.Consultant.User,
                AppointmentDate=x.AppointmentDate,
                AppointmentState=x.AppointmentState,
                AppointmentTime=x.AppointmentTime,
                UpdatedTime=x.UpdatedTime,
                
            }).ToList();
            return View(appointmentViewModel);
        }
    }
}
