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
        public AppointmentTime AppointmentTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public Consultant Consultant { get; set; }
        public Customer Customer { get; set; }

    }
    
}
 public enum AppointmentTime
{
    Saat00_01 = 0,
    Saat01_02 = 1,
    Saat02_03 = 2,
    Saat03_04 = 3,
    Saat04_05 = 4,
    Saat05_06 = 5,
    Saat06_07 = 6,
    Saat07_08 = 7,
    Saat08_09 = 8,
    Saat09_10 = 9,
    Saat10_11 = 10,
    Saat11_12 = 11,
    Saat12_13 = 12,
    Saat13_14 = 13,
    Saat14_15 = 14,
    Saat15_16 = 15,
    Saat16_17 = 16,
    Saat17_18 = 17,
    Saat18_19 = 18,
    Saat19_20 = 19,
    Saat20_21 = 20,
    Saat21_22 = 21,
    Saat22_23 = 22,
    Saat23_00 = 23
}