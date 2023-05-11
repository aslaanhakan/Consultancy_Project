using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Consultancy_Project.MVC.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private IAppointmentService _appointmentService;
        private IConsultantService _consultantService;
        private IAvailableService _availableService;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public AppointmentController(IAppointmentService appointmentService, IConsultantService consultantService, UserManager<User> userManager, RoleManager<Role> roleManager, IAvailableService availableService)
        {
            _appointmentService = appointmentService;
            _consultantService = consultantService;
            _userManager = userManager;
            _roleManager = roleManager;
            _availableService = availableService;
        }

        public async Task<IActionResult> Index(string id)
        {
            var name = id;
            var user = await _userManager.FindByNameAsync(name);
            var userRole = await _userManager.GetRolesAsync(user);
            if (userRole[0]=="Admin")
            {
                var appointmentAdmin = await _appointmentService.GetAllFullDataAsync();
                var appointmentViewModelAdmin = appointmentAdmin.Select(x => new AppointmentViewModel
                {
                    Id = x.Id,
                    UserCustomer = x.Customer.User,
                    UserConsultant = x.Consultant.User,
                    AppointmentDate = x.AppointmentDate,
                    AppointmentState = x.AppointmentState,
                    AppointmentTime = x.AppointmentTime,
                    UpdatedTime = x.UpdatedTime,
                    Price=x.Price,
                }).ToList();
                return View(appointmentViewModelAdmin);
            }
            var appointment = await _appointmentService.GetAllDataByUserIdAsync(user.Id, userRole[0]);
            var appointmentViewModel = appointment.Select(x => new AppointmentViewModel
            {
                Id = x.Id,
                UserCustomer = x.Customer.User,
                UserConsultant = x.Consultant.User,
                AppointmentDate = x.AppointmentDate,
                AppointmentState = x.AppointmentState,
                AppointmentTime = x.AppointmentTime,
                UpdatedTime = x.UpdatedTime,
                Price = x.Price,
            }).ToList();
            return View(appointmentViewModel);
        }
        public async Task<IActionResult> Available(string id)
        {
            var name = id;
            var user = await _userManager.FindByNameAsync(name);
            var consultant = await _consultantService.GetConsultantAvailablesByUserIdAsync(user.Id);
            var groupDate = await _availableService.GetAvailablesGroupByDateAsync(consultant.Id);
            var workingHours = await _availableService.GetAllWorkingHours();
            //DateTime dateTime = DateTime.Parse(groupDate[0].ToString());
            //DateOnly dateOnly = DateOnly.FromDateTime(dateTime);
            var availableViewModel = new AvailableViewModel
            {
                Consultant = consultant,
                User = consultant.User,
                GroupDate = groupDate,
                WorkingHours = workingHours,
                ActiveAvailable = consultant.Availables,
            };
            return View(availableViewModel);
        }
    }
}
