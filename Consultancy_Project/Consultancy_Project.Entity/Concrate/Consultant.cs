using Consultancy_Project.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Consultant : IBaseEntity

    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Promotion { get; set; }
        public JobTitle JobTitle { get; set; }
        public List<Education> Educations { get; set; }
        public List<Specialization> Specializations { get; set; }
        public List<Certificate> Certificates { get; set; }

    }
}
