using System;
using BudalaceanCiprianLab7.Data;
using System.IO;

namespace BudalaceanCiprianLab7
{
    public partial class App : Application
    {
        static AppDatabase? database;

        public static AppDatabase Database
        {
            get
            {
                if (database == null)
                {
                    string dbPath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "ClinicApp.db3");
                    database = new AppDatabase(dbPath);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
