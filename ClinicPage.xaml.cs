namespace BudalaceanCiprianLab7;
using BudalaceanCiprianLab7.Models;

using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices.Sensors;
using System.Linq;

public partial class ClinicPage : ContentPage
{
    public ClinicPage()
    {
        InitializeComponent();
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var clinic = (Clinic)BindingContext;
        await App.Database.SaveClinicAsync(clinic);
        await Navigation.PopAsync();
    }

    async void OnShowMapButtonClicked(object sender, EventArgs e)
    {
        var clinic = (Clinic)BindingContext;
        var address = clinic.Address;

        var locations = await Geocoding.GetLocationsAsync(address);
        var clinicLocation = locations?.FirstOrDefault();

        if (clinicLocation == null)
            return;

        var options = new MapLaunchOptions
        {
            Name = "Clinica"
        };

        await Map.OpenAsync(clinicLocation, options);
    }
}
