using Consultancy_Project.Entity.Concrate;

namespace Consultancy_Project.MVC.Areas.Admin.Models.ViewModels
{
    public class SpecializationEditViewModel
    {
        public int ConsultantId { get; set; }
        public List<Specialization> Specializations { get; set; }
        public List<Specialization> NonSpecialization { get; set; }
        public int[] IdsToAddSpecialization { get; set; }
        public int[] IdsToRemoveSpecialization { get; set; }
    }
}
