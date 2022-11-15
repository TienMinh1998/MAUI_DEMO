using DemoTransactionDone.Mvvm.ViewModels;

namespace DemoTransactionDone.Mvvm.Views;

public partial class HomePage : ContentPage
{
	private HomeViewModel homeViewModel = new HomeViewModel();
	public HomePage()
	{
		InitializeComponent();
		BindingContext = homeViewModel;
	}
}