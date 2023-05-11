using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;

namespace Consultancy_Project.MVC.Models
{
    public class AvailableViewModel
    {
        public User User { get; set; }
        public Consultant Consultant { get; set; }
        public List<Available> ActiveAvailable { get; set; }
        public List<DateOnly> GroupDate { get; set; }
        public List<WorkingHours> WorkingHours { get; set; }
    }
}
