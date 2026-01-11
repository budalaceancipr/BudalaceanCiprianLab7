using Microsoft.Maui.Controls;
using BudalaceanCiprianLab7.Data;
using BudalaceanCiprianLab7.Models;

namespace BudalaceanCiprianLab7
{
    public partial class ServiceDetailPage : ContentPage
    {
        public ServiceDetailPage(Service service)
        {
            InitializeComponent();
            ServiceNameLabel.Text = service.Name;
            PriceLabel.Text = service.Price.ToString("C");
        }
    }
}
