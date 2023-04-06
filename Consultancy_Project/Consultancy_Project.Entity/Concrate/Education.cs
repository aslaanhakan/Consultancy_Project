using Consultancy_Project.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Education : IBaseEntity
    {
        public Guid Id { get; set; }
        public string School { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string DegreeofGraduation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime GraduationTime { get; set; }
    }
}
