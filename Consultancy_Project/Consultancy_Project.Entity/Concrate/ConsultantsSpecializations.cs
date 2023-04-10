using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class ConsultantsSpecializations
    {
        public int ConsultantId { get; set; }
        public int SpecializationId { get; set; }
        public virtual Consultant Consultant { get; set; }
        public virtual Specialization Specialization { get; set; }

    }
}
