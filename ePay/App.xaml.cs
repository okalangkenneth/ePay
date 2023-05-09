using ePay.Views.Welcome;

namespace ePay;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new WelcomePage());

    }
}
