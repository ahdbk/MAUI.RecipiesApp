using MyRecipiesApp.Models;
using MyRecipiesApp.ViewModel;
using System.Collections.ObjectModel;
using static MyRecipiesApp.Common.RecipesViewModel;
using static MyRecipiesApp.Pages.HomePage;

namespace MyRecipiesApp.Pages
{
    public partial class RecepiePage : ContentPage
    {
        public ObservableCollection<string> toto { get; set; } = new ObservableCollection<string> { };

        public bool IsCocktail { get; set; }
        public RecepiePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Application.Current.UserAppTheme = AppTheme.Light;

            this.BindingContext = this;
            //this.IsCocktail = ((Recepie)this.BindingContext).Category == RecipeCategoryEnum.Cocktail;
        }

        public async void OnTappedGoBack(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
    }
}