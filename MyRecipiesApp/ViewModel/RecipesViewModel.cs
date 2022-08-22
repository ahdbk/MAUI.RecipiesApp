using MyRecipiesApp.Models;
using System.Collections.ObjectModel;
using System.Linq;
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
        private RecipeCategoryEnum _selectedCategory;
        private IEnumerable<Recepie> AllRecepies { get; set; }
        public RecipeCategoryEnum SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;

                var filtredRecepies = AllRecepies.Where(x => x.Category == value);


                foreach (var item in AllRecepies)
                    if (!filtredRecepies.Contains(item))
                        Recepies.Remove(item);
                    else if (!Recepies.Contains(item))
                        Recepies.Add(item);

            }
        }


        public RecipesViewModel()
        {
            this.AllRecepies = GetAllRecepies();
            this.Recepies = new ObservableCollection<Recepie>(AllRecepies);
            this.Categories = new ObservableCollection<RecipeCategory>(GetCategories());
            this.SelectedCategory = RecipeCategoryEnum.Meal;

            this.PopularRecepies = new ObservableCollection<Recepie>(
                (AllRecepies.OrderByDescending(x => x.Rating))
            );
        }

        void OnColorsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // Perform required operation
        }

        internal IEnumerable<RecipeCategory> GetCategories() => new List<RecipeCategory>()
        {
            new RecipeCategory{ Label = "Meal", Value = RecipeCategoryEnum.Meal},
            new RecipeCategory{ Label = "Pizza", Value = RecipeCategoryEnum.Pizza},
            new RecipeCategory{ Label = "Desert", Value = RecipeCategoryEnum.Desert},
            new RecipeCategory{ Label = "Cocktail", Value = RecipeCategoryEnum.Cocktail}
        };

        internal IEnumerable<Recepie> GetAllRecepies() => GetDummyData();

        private IEnumerable<Recepie> GetDummyData() =>
            new List<Recepie>
            {
                new()
                {
                    Title = "Brokoly Rice",
                    PrepTime = "30 min",
                    Category= RecipeCategoryEnum.Meal,
                    Description =
                        "This Easy Cheesy Broccoli Rice is a fast and flavorful side when you don't have time to make a classic Broccoli Cheddar Casserole.",
                    Ingredients = new List<string>()
                    {
                        "2 cups rice",
                        "3 cups water",
                        "1 lb broccoli ",
                        "2 Tbsp butter",
                        "1/4 tsp garlic",
                        "1 Pepper",
                        "1/4 cup Parmesan",
                        "1 cup shredded  cheddar"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Place the rice in a large pot and add 3 cups water. Place a lid on the pot and bring it up to a boil over high heat. Once it reaches a boil, turn the heat down to low and let it simmer for 15 minutes." },
                         {"2","After simmering for 15 minutes, turn the heat off and let the rice rest without removing the lid for an additional 5 minutes." },
                         {"3","While the rice is cooking, chop the broccoli florets into tiny pieces." },
                         {"4","Once the rice has cooked, fluff it gently with a fork. Add the butter, salt, garlic powder, cayenne, and some freshly cracked pepper. Fold the butter and spices into the rice until fairly well combined" },
                         {"5","Add the chopped broccoli and gently fold it into the rice. The broccoli should bring the temperature of the rice down just to the point where it is hot/warm, but not so hot that the cheese immediately melts when stirred into the rice." },
                         {"6","Finally, add the Parmesan and cheddar cheeses, and fold to combine again. Taste and adjust the salt or butter if needed. Serve immediately." },

                    },
                    Image = "rice_brokoly.png",
                    Color = ColorPalet.Blue,
                    Rating = 1.5
                },
                new()
                {
                    Title = "Classic Burger",
                    PrepTime = "Yata !!",
                    Category= RecipeCategoryEnum.Meal,
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
                    PrepTime = "Mama miya",
                    Category= RecipeCategoryEnum.Pizza,
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
                    Category= RecipeCategoryEnum.Meal,
                    PrepTime = "Qualita !!!",
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
                    PrepTime = "Vitamin Sea",
                    Category= RecipeCategoryEnum.Meal,
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
                    PrepTime = "Sweet and spicy",
                    Category= RecipeCategoryEnum.Desert,
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
                    PrepTime = "Pure energy",
                    Category= RecipeCategoryEnum.Cocktail,
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
                    PrepTime = "Arrivaaa !!!!",
                    Category= RecipeCategoryEnum.Cocktail,
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
                    PrepTime = "ouh !! ",
                    Category= RecipeCategoryEnum.Cocktail,
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
