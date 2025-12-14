namespace BudalaceanCiprianLab7;
using BudalaceanCiprianLab7.Models;

using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices.Sensors;
using System.Linq;

public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var shop = (Shop)BindingContext;
        await App.Database.SaveShopAsync(shop);
        await Navigation.PopAsync();
    }

    async void OnShowMapButtonClicked(object sender, EventArgs e)
    {
        var shop = (Shop)BindingContext;
        var address = shop.Address;

        var locations = await Geocoding.GetLocationsAsync(address);
        var shopLocation = locations?.FirstOrDefault();

        if (shopLocation == null)
            return;

        var options = new MapLaunchOptions
        {
            Name = "Magazinul meu preferat"
        };

        await Map.OpenAsync(shopLocation, options);
    }
}
