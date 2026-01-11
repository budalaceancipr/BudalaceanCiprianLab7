using BudalaceanCiprianLab7.Models;

namespace BudalaceanCiprianLab7;

public partial class AppointmentDetailPage : ContentPage
{
    private Appointment? _appointment;

    public AppointmentDetailPage(Appointment? appointment = null)
    {
        InitializeComponent();
        _appointment = appointment;

        if (_appointment != null)
        {
            ClinicIdEntry.Text = _appointment.ClinicID.ToString();
            UserIdEntry.Text = _appointment.UserID.ToString();
            AppointmentDatePicker.Date = _appointment.AppointmentDate;
            DeleteButton.IsVisible = true;
        }
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        int clinicId = int.TryParse(ClinicIdEntry.Text, out int cid) ? cid : 0;
        int userId = int.TryParse(UserIdEntry.Text, out int uid) ? uid : 0;

        if (clinicId == 0 || userId == 0)
        {
            await DisplayAlert("Error", "Clinic ID and User ID must be valid numbers", "OK");
            return;
        }

        if (_appointment == null)
            _appointment = new Appointment();

        _appointment.ClinicID = clinicId;
        _appointment.UserID = userId;
        _appointment.AppointmentDate = AppointmentDatePicker.Date;

        await App.Database.SaveAppointmentAsync(_appointment);
        await Navigation.PopAsync();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (_appointment != null)
        {
            await App.Database.DeleteAppointmentAsync(_appointment);
            await Navigation.PopAsync();
        }
    }
}
