using BudalaceanCiprianLab7.Models;

namespace BudalaceanCiprianLab7;

public partial class ProductPage : ContentPage
{
    ShopList sl;

    public ProductPage(ShopList slist)
    {
        InitializeComponent();
        sl = slist;
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await App.Database.SaveProductAsync(product);
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var product = listView.SelectedItem as Product;
        if (product != null)
        {
            await App.Database.DeleteProductAsync(product);
            listView.ItemsSource = await App.Database.GetProductsAsync();
        }
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }

    async void OnAddButtonClicked(object sender, EventArgs e)
    {
        var product = listView.SelectedItem as Product;
        if (product != null)
        {
            var lp = new ListProduct()
            {
                ShopListID = sl.ID,
                ProductID = product.ID
            };

            await App.Database.SaveListProductAsync(lp);

            if (product.ListProducts == null)
                product.ListProducts = new List<ListProduct>();

            product.ListProducts.Add(lp);

            await Navigation.PopAsync();
        }
    }
}
