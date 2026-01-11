using SQLite;

namespace BudalaceanCiprianLab7.Models
{
    public class AppointmentService
    {
        [PrimaryKey, AutoIncrement]
        public int AppointmentServiceId { get; set; }

        public int ServiceId { get; set; }

        public int AppointmentId { get; set; }

        public decimal Price { get; set; }
    }
}
