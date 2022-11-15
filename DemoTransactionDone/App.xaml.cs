using DemoTransactionDone.Mvvm.Views;

namespace DemoTransactionDone;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
     
    }
}
