using SQLite;

namespace BudalaceanCiprianLab7.Models
{
    public class Clinic
    {
        [PrimaryKey, AutoIncrement]
        public int ClinicId { get; set; }

        [NotNull]
        public string Name { get; set; } = string.Empty;


        public string Address { get; set; } = string.Empty;
    }
}
