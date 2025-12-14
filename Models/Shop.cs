using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudalaceanCiprianLab7.Models
{
    public class Shop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string ShopName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public string ShopDetails => $"{ShopName}\n{Address}";

        [OneToMany]
        public List<ShopList> ShopLists { get; set; } = new();
    }
}