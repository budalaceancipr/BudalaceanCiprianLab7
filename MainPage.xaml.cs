namespace BudalaceanCiprianLab7
{
    public partial class MainPage : ContentPage
    {
        int count = 0; // contor click-uri

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnAppointmentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppointmentEntryPage());
        }

        private async void OnClinicsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClinicPage());
        }
    }
}
