using Consultancy_Project.Entity.Abstract;
using Consultancy_Project.Entity.Concrate.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Consultant : IBaseEntity

    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string Promotion { get; set; }        
        public decimal? VisitsPrice { get; set; }
        public string JobTitle { get; set; }
        public virtual List<Education> Educations { get; set; }
        public virtual List<Specialization> Specializations { get; set; }
        public virtual List<Certificate> Certificates { get; set; }
        public virtual List<CustomersConsultans> CustomersConsultans { get; set; }

    }
}
