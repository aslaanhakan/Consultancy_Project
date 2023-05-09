using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Entity.Concrate
{
    public class Calendar
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string TimeRange { get; set; }

    }
}
