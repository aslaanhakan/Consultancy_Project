using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Consultancy_Project.MVC.Controllers
{
    public class AppointmentController : Controller
    {
        private IAppointmentService _appointmentService;
        private IConsultantService _consultantService;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public AppointmentController(IAppointmentService appointmentService, IConsultantService consultantService, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _appointmentService = appointmentService;
            _consultantService = consultantService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index(string id)
        {
            var name = id;
            var user = await _userManager.FindByNameAsync(name);
            var userRole = await _userManager.GetRolesAsync(user);

            var appointment = await _appointmentService.GetAllDataByUserIdAsync(user.Id, userRole[0]);
            //var appointment = await _appointmentService.GetAllFullDataAsync();
            var appointmentViewModel = appointment.Select(x => new AppointmentViewModel
            {
                Id = x.Id,
                UserCustomer = x.Customer.User,
                UserConsultant = x.Consultant.User,
                AppointmentDate = x.AppointmentDate,
                AppointmentState = x.AppointmentState,
                AppointmentTime = x.AppointmentTime,
                UpdatedTime = x.UpdatedTime,

            }).ToList();
            return View(appointmentViewModel);
        }
        public async Task<IActionResult> AppointmentDetails(int id)
        {

            return View();
        }
    }
}
