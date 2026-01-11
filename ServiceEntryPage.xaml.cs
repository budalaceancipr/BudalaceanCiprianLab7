using BudalaceanCiprianLab7.Data;
using BudalaceanCiprianLab7.Models;
using Microsoft.Maui.Controls;
using System;

namespace BudalaceanCiprianLab7
{
    public partial class ServiceEntryPage : ContentPage
    {
        private AppDatabase _database;
        private Service _service;

        public ServiceEntryPage(AppDatabase database, Service? service = null)
        {
            InitializeComponent();

            _database = database;
            _service = service ?? new Service();

            if (service != null)
            {
                NameEntry.Text = _service.Name;
                PriceEntry.Text = _service.Price.ToString();
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            _service.Name = NameEntry.Text;
            _service.Price = decimal.TryParse(PriceEntry.Text, out var price) ? price : 0;

            await _database.SaveServiceAsync(_service);
            await Navigation.PopAsync();
        }
    }
}
