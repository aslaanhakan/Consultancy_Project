using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using System.ComponentModel.DataAnnotations;

namespace Consultancy_Project.MVC.Models
{
    public class AppointmentCreateViewModel
    {
        public int ConsultantId { get; set; }
        [Required(ErrorMessage = "Randevu tarihi seçilmelidir.")]
        public DateOnly Date { get; set; }
        [Required(ErrorMessage = "Randevu saati seçilmelidir.")]
        public int SelectedHour { get; set; }
        public User User { get; set; }
        public Consultant Consultant { get; set; }
        public List<Available> ActiveAvailable { get; set; }
        public List<DateOnly> GroupDate { get; set; }
        public List<WorkingHours> WorkingHours { get; set; }
        public List<Available> DateOfAvailables { get; set; }
    }
}
