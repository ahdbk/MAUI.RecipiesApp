using MyRecipiesApp.Pages;
using MyRecipiesApp.ViewModel;
using static MyRecipiesApp.Pages.HomePage;

namespace MyRecipiesApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomePage());
    }
}
