using ProductAppMobile.Views;

namespace ProductAppMobile;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// Registering the Page into Routes
		Routing.RegisterRoute("ProductDetails", typeof(ProductDetails));
	}

}
