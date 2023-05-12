using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Consultancy_Project.MVC.Controllers
{
    public class AvailableController : Controller
    {
        private IConsultantService _consultantService;
        private IAvailableService _availableService;
        private readonly UserManager<User> _userManager;

        public AvailableController(IConsultantService consultantService, IAvailableService availableService, UserManager<User> userManager)
        {
            _consultantService = consultantService;
            _availableService = availableService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string id)
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
        [HttpGet]
        public async Task<IActionResult> Add (DateOnly date,int id)
        {

            var availableOfDate = await _availableService.GetAllAvailablesOfDateAsync(date,id);
            var workingHours = await _availableService.GetAllWorkingHours();
            var availableViewModel = new AvailableAddViewModel()
            {
                WorkingHours= workingHours,
                ConsultantId = id,
                DateOfAvailables = availableOfDate,
            };
            return View(availableViewModel);
        }
    }
}
