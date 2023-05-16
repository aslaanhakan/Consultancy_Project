using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate;
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
        private ICustomerService _customerService;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public AppointmentController(IAppointmentService appointmentService, IConsultantService consultantService, UserManager<User> userManager, RoleManager<Role> roleManager, IAvailableService availableService, ICustomerService customerService)
        {
            _appointmentService = appointmentService;
            _consultantService = consultantService;
            _userManager = userManager;
            _roleManager = roleManager;
            _availableService = availableService;
            _customerService = customerService;
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
        [HttpGet]
        public async Task<IActionResult> TakeAppointment(int id)
        {
            var consultant = await _consultantService.GetConsultantFullDataByIdAsync(id);
            var groupDate = await _availableService.GetAvailablesGroupByDateAsync(consultant.Id);
            var appointmentCreateViewModel = new AppointmentCreateViewModel
            {
                ConsultantId = consultant.Id,
                User = consultant.User,
                GroupDate = groupDate,
                ActiveAvailable = consultant.Availables,
            };
            return View(appointmentCreateViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> TakeAppointment(AppointmentCreateViewModel appointmentCreateViewModel)
        {
            var workingHours = await _availableService.GetAllWorkingHours();
            if (ModelState.IsValid)
            {
                var customerUser = await _userManager.FindByNameAsync(User.Identity.Name);
                var customer = await _customerService.GetByUserIdAsync(customerUser.Id);
                var appointment = new Appointment()
                {
                    ConsultantId = appointmentCreateViewModel.ConsultantId,
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now,
                    AppointmentTime = workingHours.Where(x => x.Id == appointmentCreateViewModel.SelectedHour).FirstOrDefault().Hour,
                    AppointmentDate= appointmentCreateViewModel.Date,
                    AppointmentState= AppointmentState.Waiting,
                    Price=100,
                    CustomerId=customer.Id,
                    

                };
               await _appointmentService.CreateAsync(appointment);
                return RedirectToAction("Index", "Appointment" , new {id=customerUser.UserName});

            }
            return View(appointmentCreateViewModel);
        }
    }
}
