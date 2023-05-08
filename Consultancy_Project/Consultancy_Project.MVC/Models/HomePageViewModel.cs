using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;

namespace Consultancy_Project.MVC.Models
{
    public class HomePageViewModel
    {
        public List<Consultant> Consultants { get; set; }
        public List<Specialization> Specializations { get; set; }
    }
}
