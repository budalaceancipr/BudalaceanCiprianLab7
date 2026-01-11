using BudalaceanCiprianLab7.Data;
using BudalaceanCiprianLab7.Models;
using Microsoft.Maui.Controls;
using System;

namespace BudalaceanCiprianLab7
{
    public partial class ServicePage : ContentPage
    {
        private AppDatabase _database;

        public ServicePage(AppDatabase database)
        {
            InitializeComponent();
            _database = database;
            LoadServices();
        }

        private async void LoadServices()
        {
            var services = await _database.GetServicesAsync();
            ServicesCollectionView.ItemsSource = services;
        }

        private async void OnAddServiceClicked(object sender, EventArgs e)
        {
            // Pentru un serviciu nou, nu trimitem nimic
            await Navigation.PushAsync(new ServiceEntryPage(_database)); // ⚠️ Trebuie să corectăm și ServiceEntryPage
        }

        private async void OnServiceSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;

            if (e.CurrentSelection[0] is Service selectedService)
            {
                await Navigation.PushAsync(new ServiceEntryPage(_database, selectedService)); // editare serviciu
            }

            // Deselect item
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}
