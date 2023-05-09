using Consultancy_Project.Entity.Abstract;
using Consultancy_Project.Entity.Concrate.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Customer : IBaseEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual List<CustomersConsultans> CustomersConsultans { get; set; }
    }
}
