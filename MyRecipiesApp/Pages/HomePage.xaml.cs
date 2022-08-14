using System.Collections.ObjectModel;
using MyRecipiesApp.Models;

namespace MyRecipiesApp.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Application.Current.UserAppTheme = AppTheme.Light;

        }


    }
}