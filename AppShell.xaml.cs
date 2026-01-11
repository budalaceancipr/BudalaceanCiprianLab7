using Microsoft.Maui.Storage;

namespace BudalaceanCiprianLab7;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        string loggedUser = Preferences.Default.Get<string>("LoggedInUserEmail", string.Empty);

        if (string.IsNullOrEmpty(loggedUser))
        {
            Application.Current!.MainPage = new NavigationPage(new LoginPage());
        }
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        Preferences.Default.Remove("LoggedInUserEmail");
        Application.Current!.MainPage = new NavigationPage(new LoginPage());
    }
}
