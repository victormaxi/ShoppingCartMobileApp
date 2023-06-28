using ProductAppMobile.Models;
using System.ComponentModel;

namespace ProductAppMobile.Views;

[QueryProperty(nameof(Product), "product")]
public partial class ProductDetails : ContentPage, IQueryAttributable, INotifyPropertyChanged
{
    public Product product { get; private set; }
    public ProductDetails()
	{
		InitializeComponent();
        BindingContext = this;
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        product = query["product"] as Product;
        OnPropertyChanged("product");
    }
}