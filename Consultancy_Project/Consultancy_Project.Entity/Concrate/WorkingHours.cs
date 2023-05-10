namespace Consultancy_Project.Entity.Concrate
{
    public class WorkingHours
    {
        public int Id { get; set; }
        public string AppoinmentHour { get; set; }
        public List<Calendar> Calendars { get; set; }
    }
}