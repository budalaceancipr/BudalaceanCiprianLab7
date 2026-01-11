using BudalaceanCiprianLab7.Models;

namespace BudalaceanCiprianLab7;

public partial class AppointmentEntryPage : ContentPage
{
    public AppointmentEntryPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        AppointmentListView.ItemsSource = await App.Database.GetAppointmentsAsync();
    }

    private async void OnAppointmentAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AppointmentDetailPage());
    }

    private async void OnAppointmentSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Appointment selectedAppointment)
        {
            await Navigation.PushAsync(new AppointmentDetailPage(selectedAppointment));
        }
    }
}
