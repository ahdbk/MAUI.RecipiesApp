using System.Collections.ObjectModel;
using MyRecipiesApp.ViewModel;

namespace MyRecipiesApp.Pages
{
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<Recepie> Recepies { get; set; } = new ObservableCollection<Recepie> { };
        public ObservableCollection<Recepie> PopularRecepies { get; set; } = new ObservableCollection<Recepie> { };

        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.Recepies = new  ObservableCollection<Recepie>(GetDummyData());
            this.PopularRecepies = new ObservableCollection<Recepie>(GetDummyData().OrderByDescending(x => x.Rating));

            Application.Current.UserAppTheme = AppTheme.Light;
            this.BindingContext = this;

        }

        public IEnumerable<Recepie> GetDummyData() => new List<Recepie>
        {
            new () { Title="Brokoly Rice", SubTitle="Miam Miam !!",Image= "rice_brokoly.png",Color= ColorPalet.Blue,Rating=1.5},
            new () { Title="Classic Burger", SubTitle="Yata !!",Image= "burger.png" ,Color= ColorPalet.Peach,Rating=4.3},
            new () { Title="Pizza", SubTitle="Mama miya",Image= "pizza.png",Color= ColorPalet.Yellow,Rating=2.5},
            new () { Title="Spagetti Pesto", SubTitle="Qualita !!!",Image= "pasta_pesto.png",Color= ColorPalet.Blue,Rating=3.0},
            new () { Title="Gambas Pasta", SubTitle="Vitamin Sea",Image= "pasta_gambas.png",Color= ColorPalet.Beige,Rating=3.4},
            new () { Title="Cinnamon Rolls", SubTitle="Sweet and spicy",Image= "cinnamon_roll.png",Color= ColorPalet.Peach,Rating=4.8},
            new () { Title="Orange on Fire", SubTitle="Pure energy",Image= "orange_fire.png",Color= ColorPalet.Blue,Rating=3.7},
            new () { Title="Mojito", SubTitle="Arrivaaa !!!!",Image= "mojito.png",Color= ColorPalet.Yellow,Rating=3.5},
            new () { Title="Spicy Red", SubTitle="ouh !! ",Image= "strawberry.png",Color= ColorPalet.Beige,Rating=4.5},
        };

        public static class ColorPalet
        {
            public static Color Peach { get; } = new Color(255,179,179);
            public static Color Yellow { get; } = new Color(255,219,164);
            public static Color BlueDark { get; } = new Color(110,133,183);
            public static Color Blue { get; } = new Color(193,239,255);
            public static Color Beige { get; } = new Color(233,218,193);
            public static Color Teal { get; } = new Color(84,186,185);
        }
    }
}