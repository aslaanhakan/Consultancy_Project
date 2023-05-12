using Consultancy_Project.Entity.Concrate;

namespace Consultancy_Project.MVC.Models
{
    public class AvailableAddViewModel
    {
        public int ConsultantId { get; set; }
        public List<WorkingHours> WorkingHours { get; set; }
        public List<Available> DateOfAvailables { get; set; }

    }
}
