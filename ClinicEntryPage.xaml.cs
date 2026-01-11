using BudalaceanCiprianLab7.Models;
using BudalaceanCiprianLab7.Data;

namespace BudalaceanCiprianLab7
{
    public partial class ClinicEntryPage : ContentPage
    {
        private readonly AppDatabase _database;

        public ClinicEntryPage(AppDatabase database)
        {
            InitializeComponent();
            _database = database;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var clinic = new Clinic
            {
                Name = NameEntry.Text,
                Address = AddressEntry.Text,
                Phone = PhoneEntry.Text
            };

            await _database.SaveClinicAsync(clinic);
            await DisplayAlert("Success", "Clinic saved!", "OK");
        }
    }
}
