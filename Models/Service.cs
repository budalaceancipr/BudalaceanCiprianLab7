using SQLite;

namespace BudalaceanCiprianLab7.Models
{
    public class Service
    {
        [PrimaryKey, AutoIncrement]
        public int ServiceId { get; set; }

        [NotNull]
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
