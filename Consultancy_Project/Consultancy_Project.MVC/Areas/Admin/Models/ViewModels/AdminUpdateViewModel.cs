namespace Consultancy_Project.MVC.Areas.Admin.Models.ViewModels
{
    public class AdminUpdateViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool PhoneConfirmed { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
