using BudalaceanCiprianLab7.Models;

namespace BudalaceanCiprianLab7;

public partial class AppointmentPage : ContentPage
{
    public AppointmentPage()
    {
        InitializeComponent();
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var appointment = (Appointment)BindingContext;
        appointment.AppointmentDate = DateTime.UtcNow;
        await App.Database.SaveAppointmentAsync(appointment);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var appointment = (Appointment)BindingContext;
        await App.Database.DeleteAppointmentAsync(appointment);
        await Navigation.PopAsync();
    }

    async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ServicePage((Appointment)this.BindingContext)
        {
            BindingContext = new Service()
        });
    }
}
