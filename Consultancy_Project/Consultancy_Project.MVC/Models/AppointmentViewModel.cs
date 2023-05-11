using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;

namespace Consultancy_Project.MVC.Models
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public int CustomerId { get; set; }
        public decimal Price { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public AppointmentState AppointmentState { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public User UserConsultant { get; set; }
        public User UserCustomer { get; set; }
        public Consultant Consultant { get; set; }
        public Customer Customer { get; set; }
    }
}
