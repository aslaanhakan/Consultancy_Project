using Consultancy_Project.Entity.Concrate.Identity;

namespace Consultancy_Project.MVC.Areas.Admin.Models.ViewModels
{
    public class AdminAddViewModel
    {
        public List<User> Members { get; set; }
        public List<User> NonMembers { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToRemove { get; set; }
    }
}
