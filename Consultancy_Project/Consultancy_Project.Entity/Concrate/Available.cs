using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Available
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public int ConsultantId { get; set; }
        public DateOnly Date { get; set; }
        public int WorkingHoursId { get; set; }
        public virtual WorkingHours WorkingHours { get; set; }
        public virtual Consultant Consultant { get; set; }
    }
}
