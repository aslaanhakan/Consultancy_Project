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
        public DateOnly AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public decimal Price { get; set; }
        public AppointmentState AppointmentState { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public virtual Consultant Consultant { get; set; }
        public virtual Customer Customer { get; set; }

    }
    
}
public enum AppointmentState
{
    Waiting =0,
    Successful = 1,
    Unsuccessful = 2,
    Cancellation =3,
}