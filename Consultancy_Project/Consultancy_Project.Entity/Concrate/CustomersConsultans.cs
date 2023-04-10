using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class CustomersConsultans
    {
        public int CustomerId { get; set; }
        public int ConsultantId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Consultant Consultant { get; set; }

    }
}
