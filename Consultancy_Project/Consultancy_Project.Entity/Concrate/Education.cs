using Consultancy_Project.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Education : IBaseEntity
    {
        public Guid Id { get; set; }
        public string SchoolName { get; set; }
        public string FacultyName { get; set; }
        public string DepartmentName { get; set; }
        public string DegreeofGraduation { get; set; }
        public int StartYear { get; set; }
        public int GraduationYear { get; set; }
        public int ConsultantId { get; set; }
        public virtual Consultant Consultant { get; set; }
    }
}
