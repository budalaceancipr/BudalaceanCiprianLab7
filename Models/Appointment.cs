using SQLite;

namespace BudalaceanCiprianLab7.Models
{
    public class Appointment
    {
        [PrimaryKey, AutoIncrement]
        public int AppointmentId { get; set; }

        public int ClinicID { get; set; }
        public int UserID { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
