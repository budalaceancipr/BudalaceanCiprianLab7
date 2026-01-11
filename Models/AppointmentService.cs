using SQLite;

namespace BudalaceanCiprianLab7.Models
{
    public class AppointmentService
    {
        [PrimaryKey, AutoIncrement]
        public int AppointmentServiceId { get; set; }

        // legătura cu Service
        public int ServiceId { get; set; }

        // legătura cu Appointment
        public int AppointmentId { get; set; }

        // informații suplimentare
        public decimal Price { get; set; }
    }
}
