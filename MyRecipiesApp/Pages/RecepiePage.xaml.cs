using MyRecipiesApp.ViewModel;
using System.Collections.ObjectModel;
using static MyRecipiesApp.Pages.HomePage;

namespace MyRecipiesApp.Pages
{
    public partial class RecepiePage : ContentPage
    {
        public ObservableCollection<string> toto { get; set; } = new ObservableCollection<string> { };

        public RecepiePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Colors.White;
            navigationPage.BarTextColor = Colors.Black;

            this.BindingContext =  new Recepie() {
                Title = "Spagetti Pesto",
                SubTitle = "Qualita !!!",
                Image = "pasta_pesto.png",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                Color = ColorPalet.Blue,
                Ingredients = (new List<string> { "500 ml Milk", "500 ml Milk" , "500 ml Milk" , "500 ml Milk" , "500 ml Milk" , "500 ml Milk" , "500 ml Milk" }).AsEnumerable<string>(),
                Rating = 3.0
            };
        }
    }
}