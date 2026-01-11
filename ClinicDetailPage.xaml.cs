using BudalaceanCiprianLab7.Models;

namespace BudalaceanCiprianLab7;

public partial class ClinicDetailPage : ContentPage
{
    private Clinic _clinic;

    public ClinicDetailPage(Clinic clinic)
    {
        InitializeComponent();
        _clinic = clinic;

        NameLabel.Text = _clinic.Name;
        AddressLabel.Text = _clinic.Address;
        PhoneLabel.Text = _clinic.Phone;
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
