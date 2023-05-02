using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Core;
using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Consultancy_Project.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Consultancy_Project.MVC.Controllers
{
    public class AccountController:Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private IImageService _imageService;
        private ICustomerService _customerService;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IImageService imageService, ICustomerService customerService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _imageService = imageService;
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now,
                };
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    var image = new Image
                    {
                        CreatedTime = DateTime.Now,
                        UpdatedTime = DateTime.Now,
                        Url = "NonPic.Jpg",
                        UserId = user.Id,
                    };
                    _imageService.CreateAsync(image);
                    var resultRole = await _userManager.AddToRoleAsync(user, "Customer");
                    var customer = new Customer
                    {
                        UserId = user.Id,
                        

                    };
                    _customerService.CreateAsync(customer);
                    if (!resultRole.Succeeded)
                    {
                        foreach (var error in resultRole.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(registerViewModel);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(loginViewModel.UserName);
                if (user == null)
                {
                    ModelState.AddModelError("", "Kullanıcı bilgileri hatalı!");
                    return View(loginViewModel);
                }
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, isPersistent: true, lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    return Redirect(loginViewModel.ReturnUrl ?? "/");
                }
                ModelState.AddModelError("", "Kullanıcı adı ya da parola hatalı!");
                
            }
            return View(loginViewModel);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> ProfileManage(string id)
        {
            string name = id;
            if (String.IsNullOrEmpty(name))
            {
                return NotFound();
            }
            //var user = await _userManager.FindByNameAsync(name);
            User user = await _userManager.Users.Where(x => x.UserName == name).Include(x => x.Image).FirstOrDefaultAsync();
            if (user == null)
            {
                return NotFound();
            }
            List<SelectListItem> genderList = new List<SelectListItem>();
            genderList.Add(new SelectListItem
            {
                Text = "Kadın",
                Value = "Kadın",
                Selected = user.Gender == "Kadın" ? true : false
            });
            genderList.Add(new SelectListItem
            {
                Text = "Erkek",
                Value = "Erkek",
                Selected = user.Gender == "Erkek" ? true : false
            });
            UserManageProfileViewModel userManageProfileViewModel = new UserManageProfileViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth,
                UserName = user.UserName,
                Address = user.Address,
                City = user.City,
                Email = user.Email,
                Phone=user.PhoneNumber,
                ImageUrl=user.Image.Url,
                GenderSelectList = genderList,
                EmailConfirmed= user.EmailConfirmed,
                PhoneConfirmed= user.PhoneNumberConfirmed,
                CreatedTime=user.CreatedTime,
                UpdateTime=user.UpdatedTime
            };
            return View(userManageProfileViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ProfileManage(UserManageProfileViewModel userManageProfileViewModel)
        {
            if (userManageProfileViewModel == null) { return NotFound(); }
            User user = await _userManager.FindByIdAsync(userManageProfileViewModel.Id);
            bool logOut = !(user.UserName == userManageProfileViewModel.UserName);
            user.FirstName = userManageProfileViewModel.FirstName;
            user.LastName = userManageProfileViewModel.LastName;
            user.Gender = userManageProfileViewModel.Gender;
            user.UserName = userManageProfileViewModel.UserName;
            user.Address = userManageProfileViewModel.Address;
            user.City = userManageProfileViewModel.City;
            user.Email = userManageProfileViewModel.Email;
            user.PhoneNumber = userManageProfileViewModel.Phone;
            user.DateOfBirth = userManageProfileViewModel.DateOfBirth;
            user.UpdatedTime= DateTime.Now;
            if (userManageProfileViewModel.ImageFile != null)
            {
                var image = new Image
                {
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now,
                    Url = Jobs.UploadImage(userManageProfileViewModel.ImageFile),
                    UserId = userManageProfileViewModel.Id
                };
                 _imageService.UpdateImage(image);
            }
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                if (logOut)
                {
                    return RedirectToAction("Logout");
                }
                return Redirect("/Account/ProfileManage/" + user.UserName);
            }
            List<SelectListItem> genderList = new List<SelectListItem>();
            genderList.Add(new SelectListItem
            {
                Text = "Kadın",
                Value = "Kadın",
                Selected = user.Gender == "Kadın" ? true : false
            });
            genderList.Add(new SelectListItem
            {
                Text = "Erkek",
                Value = "Erkek",
                Selected = user.Gender == "Erkek" ? true : false
            });

            userManageProfileViewModel.GenderSelectList = genderList;
            User userInfo = await _userManager.Users.Where(x => x.Id == userManageProfileViewModel.Id).Include(x => x.Image).FirstOrDefaultAsync();
            userManageProfileViewModel.ImageUrl = userInfo.Image.Url;
            return View(userManageProfileViewModel);
        }

    }
}
