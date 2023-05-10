using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class CalendarWorkingHours
    {
        public int CalendarId { get; set; }
        public Calendar Calendar { get; set; }
        public int WorkingHoursId { get; set; }
        public WorkingHours WorkingHours { get; set; }
    }
}
