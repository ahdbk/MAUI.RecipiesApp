using MyRecipiesApp.Models;
using System.Collections.ObjectModel;
using static MyRecipiesApp.Common.RecipesViewModel;

namespace MyRecipiesApp.ViewModel
{
    internal partial class RecipesViewModel
    {
        public ObservableCollection<Recepie> Recepies { get; set; } = new ObservableCollection<Recepie> { };
        public ObservableCollection<Recepie> PopularRecepies { get; set; } = new ObservableCollection<Recepie> { };

        public RecipesViewModel()
        {
            this.Recepies = new ObservableCollection<Recepie>(GetAllRecepies());
            this.PopularRecepies = new ObservableCollection<Recepie>((GetAllRecepies().OrderByDescending(x => x.Rating)));

        }
        internal IEnumerable<Recepie> GetAllRecepies() => GetDummyData();

        private IEnumerable<Recepie> GetDummyData() => new List<Recepie> {
      new() {
        Title = "Brokoly Rice",
          SubTitle = "Miam Miam !!",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
          Image = "rice_brokoly.png",
          Color = ColorPalet.Blue,
          Rating = 1.5
      },
      new() {
        Title = "Classic Burger",
          SubTitle = "Yata !!",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
          Image = "burger.png",
          Color = ColorPalet.Peach,
          Rating = 4.3
      },
      new() {
        Title = "Pizza",
          SubTitle = "Mama miya",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",

          Image = "pizza.png",
          Color = ColorPalet.Yellow,
          Rating = 2.5
      },
      new() {
        Title = "Spagetti Pesto",
          SubTitle = "Qualita !!!",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",

          Image = "pasta_pesto.png",
          Color = ColorPalet.Blue,
          Rating = 3.0
      },
      new() {
        Title = "Gambas Pasta",
          SubTitle = "Vitamin Sea",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",

          Image = "pasta_gambas.png",
          Color = ColorPalet.Beige, Rating = 3.4
      },
      new() {
        Title = "Cinnamon Rolls",
          SubTitle = "Sweet and spicy",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",

          Image = "cinnamon_roll.png",
          Color = ColorPalet.Peach,
          Rating = 4.8
      },
      new() {
        Title = "Orange on Fire",
          SubTitle = "Pure energy",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",

          Image = "orange_fire.png",
          Color = ColorPalet.Blue,
          Rating = 3.7
      },
      new() {
        Title = "Mojito",
          SubTitle = "Arrivaaa !!!!",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",

          Image = "mojito.png",
          Color = ColorPalet.Yellow,
          Rating = 3.5
      },
      new() {
        Title = "Spicy Red",
          SubTitle = "ouh !! ",
          Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",

          Image = "strawberry.png",
          Color = ColorPalet.Beige,
          Rating = 4.5
      },
    };
    }
}