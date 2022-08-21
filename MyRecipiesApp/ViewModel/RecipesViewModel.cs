using MyRecipiesApp.Models;
using System.Collections.ObjectModel;
using static MyRecipiesApp.Common.RecipesViewModel;

namespace MyRecipiesApp.ViewModel
{
    internal partial class RecipesViewModel
    {
        public ObservableCollection<Recepie> Recepies { get; set; } =
            new ObservableCollection<Recepie> { };

        public ObservableCollection<RecipeCategory> Categories { get; set; } =
            new ObservableCollection<RecipeCategory> { };
        public ObservableCollection<Recepie> PopularRecepies { get; set; } =
            new ObservableCollection<Recepie> { };

        public RecipesViewModel()
        {
            this.Recepies = new ObservableCollection<Recepie>(GetAllRecepies());
            this.Categories = new ObservableCollection<RecipeCategory>(GetCategories());
            this.PopularRecepies = new ObservableCollection<Recepie>(
                (GetAllRecepies().OrderByDescending(x => x.Rating))
            );
        }

        void OnColorsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // Perform required operation
        }

        internal IEnumerable<RecipeCategory> GetCategories() => new List<RecipeCategory>()
        {
            new RecipeCategory{ Label = "All", Value = RecipeCategoryEnum.All},
            new RecipeCategory{ Label = "Meal", Value = RecipeCategoryEnum.Meal},
            new RecipeCategory{ Label = "Pizza", Value = RecipeCategoryEnum.Pizza},
            new RecipeCategory{ Label = "Salad", Value = RecipeCategoryEnum.Salad},
            new RecipeCategory{ Label = "Cocktail", Value = RecipeCategoryEnum.Cocktail}
        };

        internal IEnumerable<Recepie> GetAllRecepies() => GetDummyData();

        private IEnumerable<Recepie> GetDummyData() =>
            new List<Recepie>
            {
                new()
                {
                    Title = "Brokoly Rice",
                    SubTitle = "Miam Miam !!",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "rice_brokoly.png",
                    Color = ColorPalet.Blue,
                    Rating = 1.5
                },
                new()
                {
                    Title = "Classic Burger",
                    SubTitle = "Yata !!",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "burger.png",
                    Color = ColorPalet.Peach,
                    Rating = 4.3
                },
                new()
                {
                    Title = "Pizza",
                    SubTitle = "Mama miya",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "pizza.png",
                    Color = ColorPalet.Yellow,
                    Rating = 2.5
                },
                new()
                {
                    Title = "Spagetti Pesto",
                    SubTitle = "Qualita !!!",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "pasta_pesto.png",
                    Color = ColorPalet.Blue,
                    Rating = 3.0
                },
                new()
                {
                    Title = "Gambas Pasta",
                    SubTitle = "Vitamin Sea",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "pasta_gambas.png",
                    Color = ColorPalet.Beige,
                    Rating = 3.4
                },
                new()
                {
                    Title = "Cinnamon Rolls",
                    SubTitle = "Sweet and spicy",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "cinnamon_roll.png",
                    Color = ColorPalet.Peach,
                    Rating = 4.8
                },
                new()
                {
                    Title = "Orange on Fire",
                    SubTitle = "Pure energy",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "orange_fire.png",
                    Color = ColorPalet.Blue,
                    Rating = 3.7
                },
                new()
                {
                    Title = "Mojito",
                    SubTitle = "Arrivaaa !!!!",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "mojito.png",
                    Color = ColorPalet.Yellow,
                    Rating = 3.5
                },
                new()
                {
                    Title = "Spicy Red",
                    SubTitle = "ouh !! ",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "ingredient 1",
                        "ingredient 2",
                        "ingredient 3",
                        "ingredient 4",
                        "ingredient 5",
                        "ingredient 6",
                        "ingredient 7"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"2","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"3","adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"4","In hendrerit sapien felis, ut posuere nisi ultricies vel  ultricies vel" },
                         {"5"," ultricies veltur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"6","In hendrerit sapien felis ur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"7","sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },
                         {"8","Lorem ipsum dolor sit amet, consectetur adipiscing elit. In hendrerit sapien felis, ut posuere nisi ultricies vel" },

                    },
                    Image = "strawberry.png",
                    Color = ColorPalet.Beige,
                    Rating = 4.5
                },
            };
    }
}
