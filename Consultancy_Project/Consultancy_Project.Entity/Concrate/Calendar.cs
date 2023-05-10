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
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public int ConsultantId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public Consultant Consultant { get; set; }
    }
}
