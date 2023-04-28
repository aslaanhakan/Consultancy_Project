using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Core;
using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Consultancy_Project.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CustomerController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private IImageService _imageService;


        public CustomerController(UserManager<User> userManager, RoleManager<Role> roleManager, IImageService imageService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _imageService = imageService;
        }

        public async Task<IActionResult> Index()
        {
            var customer = await _userManager.GetUsersInRoleAsync("Customer");
            List<CustomerViewModel> customerWiew = customer.Select(a => new CustomerViewModel
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                UserName = a.UserName,
            }).ToList();
            return View(customerWiew);
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var customer = await _userManager.Users.Where(x => x.Id == id).Include(x => x.Image).FirstOrDefaultAsync();
            CustomerDetailsViewModel customerDetailsView = new CustomerDetailsViewModel()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                ImageUrl = customer.Image.Url,
                UserName = customer.UserName,
                Address = customer.Address,
                City = customer.City,
                CreatedTime = customer.CreatedTime,
                DateOfBirth = customer.DateOfBirth,
                Gender = customer.Gender,
                Phone = customer.PhoneNumber,
                UpdateTime = customer.UpdatedTime,
                EmailConfirmed = customer.EmailConfirmed,
                PhoneConfirmed = customer.PhoneNumberConfirmed
            };

            return View(customerDetailsView);
        }
        [HttpGet]

        public async Task<IActionResult> Edit(string id)
        {
            var customer = await _userManager.Users.Where(x => x.Id == id).Include(x => x.Image).FirstOrDefaultAsync();
            CustomerUpdateViewModel customerUpdateView = new CustomerUpdateViewModel()
            {
                CustomerId = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                ImageUrl = customer.Image.Url,
                UserName = customer.UserName,
                Address = customer.Address,
                City = customer.City,
                CreatedTime = customer.CreatedTime,
                DateOfBirth = customer.DateOfBirth,
                Gender = customer.Gender,
                Phone = customer.PhoneNumber,
                UpdateTime = customer.UpdatedTime,
                EmailConfirmed = customer.EmailConfirmed,
                PhoneConfirmed = customer.PhoneNumberConfirmed
            };

            return View(customerUpdateView);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CustomerUpdateViewModel customerUpdateView)
        {

            if (ModelState.IsValid)
            {
                var customer = await _userManager.Users.Where(x => x.Id == customerUpdateView.CustomerId).Include(x => x.Image).FirstOrDefaultAsync();
                customer.FirstName = customerUpdateView.FirstName;
                customer.LastName = customerUpdateView.LastName;
                customer.Email = customerUpdateView.Email;
                customer.Address = customerUpdateView.Address;
                customer.City = customerUpdateView.City;
                customer.DateOfBirth = customerUpdateView.DateOfBirth;
                customer.Gender = customerUpdateView.Gender;
                customer.PhoneNumber = customerUpdateView.Phone;
                customer.UpdatedTime = DateTime.Now;
                customer.EmailConfirmed = customerUpdateView.EmailConfirmed;
                customer.PhoneNumberConfirmed = customerUpdateView.PhoneConfirmed;
                if (customerUpdateView.ImageFile != null)
                {
                    var image = new Image
                    {
                        CreatedTime = DateTime.Now,
                        UpdatedTime = DateTime.Now,
                        Url = Jobs.UploadImage(customerUpdateView.ImageFile),
                        UserId = customerUpdateView.CustomerId
                    };

                    await _imageService.CreateAsync(image);

                }
                var result = await _userManager.UpdateAsync(customer);
                return RedirectToAction("Index");

            }
            return View(customerUpdateView);

        }
        public async Task<IActionResult> Delete(string id)
        {
            //var user = await _userManager.FindByIdAsync(id);
            var user = await _userManager.Users.Where(x => x.Id == id).Include(x => x.Image).Include(x => x.Consultant).Include(x => x.Customer).FirstOrDefaultAsync();
            var result = await _userManager.DeleteAsync(user);

            return RedirectToAction("Index");

        }
    }
}
