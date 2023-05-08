using Consultancy_Project.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Appointment : IBaseEntity
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public int CustomerId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public Consultant Consultant { get; set; }
        public Customer Customer { get; set; }

    }
}
