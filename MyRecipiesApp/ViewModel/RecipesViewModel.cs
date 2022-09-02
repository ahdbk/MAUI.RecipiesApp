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
                    PrepTime = "30 mins",
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
                        "1 cup cheddar"
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
                    Color = new Color(201,211,52),
                    Rating = 1.5
                },
                new()
                {
                    Title = "Classic Burger",
                    PrepTime = "30 mins",
                    Category= RecipeCategoryEnum.Meal,
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "1 pound beef",
                        "1 large egg",
                        "½ cup  onion",
                        "1 tbs Worceste",
                        "4 slices onion",
                        "4 hamburger buns",
                        "1/4 cup mayonnaise",
                        "1/4 cup ketchup"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","In a bowl, mix ground beef, egg, onion, bread crumbs, Worcestershire, garlic, 1/2 teaspoon salt, and 1/4 teaspoon pepper until well blended. Divide mixture into four equal portions and shape each into a patty about 4 inches wide." },
                         {"2","Lay burgers on an oiled barbecue grill over a solid bed of hot coals or high heat on a gas grill (you can hold your hand at grill level only 2 to 3 seconds); close lid on gas grill. Cook burgers, turning once, until browned on both sides and no longer pink inside (cut to test), 7 to 8 minutes total. Remove from grill." },
                         {"3","Lay buns, cut side down, on grill and cook until lightly toasted, 30 seconds to 1 minute." },
                         {"4","Spread mayonnaise and ketchup on bun bottoms. Add lettuce, tomato, burger, onion, and salt and pepper to taste. Set bun tops in place." }

                    },
                    Image = "burger.png",
                    Color =  new Color(62,187,200),
                    Rating = 4.3
                },
                new()
                {
                    Title = "Pizza",
                    PrepTime = "30 mins",
                    Category= RecipeCategoryEnum.Pizza,
                    Description =
                        "What to do when your 8-year old nephew comes to visit? Make pizza, of course!",
                    Ingredients = new List<string>()
                    {
                        "1.5 cps water",
                        "1 package yeast",
                        "3 cps flour",
                        "olive oil",
                        "2 tps salt",
                        "1 tps sugar",
                        "Firm mozzarella",
                        "Tomato sauce"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Place the warm water in the large bowl of a heavy duty stand mixer. Sprinkle the yeast over the warm water and let it sit for 5 minutes until the yeast is dissolved." },
                         {"2","After 5 minutes stir if the yeast hasn't dissolved completely. The yeast should begin to foam or bloom, indicating that the yeast is still active and alive." },
                         {"3","Add the flour, salt, sugar, and olive oil, and using the mixing paddle attachment, mix on low speed for a minute. Then replace the mixing paddle with the dough hook attachment." },
                         {"4","Knead the pizza dough on low to medium speed using the dough hook about 7-10 minutes" },
                         {"5","Spread a thin layer of olive oil over the inside of a large bowl. Place the pizza dough in the bowl and turn it around so that it gets coated with the oil." },
                         {"6","Place a pizza stone on a rack in the lower third of your oven. Preheat the oven to 475°F for at least 30 minutes, preferably an hour" },
                         {"7","Prepare your desired toppings. Note that you are not going to want to load up each pizza with a lot of toppings as the crust will end up not crisp that way" },
                         {"8","Working one ball of dough at a time, take one ball of dough and flatten it with your hands on a lightly floured work surface" },
                         {"9","Spoon on the tomato sauce, sprinkle with cheese, and place your desired toppings on the pizza. Be careful not to overload the pizza with too many toppings, or your pizza will be soggy." },

                    },
                    Image = "pizza.png",
                    Color = new Color(255,131,62),
                    Rating = 2.5
                },
                new()
                {
                    Title = "Spagetti Pesto",
                    Category= RecipeCategoryEnum.Meal,
                    PrepTime = "20 mins",
                    Description =
                        "Anyone can make a Pesto Pasta, but not everyone knows how to make a pesto pasta that’s slick with plenty of pesto sauce without adding tons of extra oil! Here’s how I make it.",
                    Ingredients = new List<string>()
                    {
                        "1 pesto",
                        "12 oz pasta",
                        "2 tsp salt",
                        "3/4 cup water",
                        "Parmesan",
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Bring a large pot of water to the boil with the salt." },
                         {"2","Add pasta and cook for the length of time per the packet." },
                         {"3","Just before draining, scoop out 1 cup of of the pasta cooking water." },
                         {"4","Drain pasta in a colander, leave it for a minute" },
                         {"5","Transfer pasta to a bowl (do not use pasta cooking pot, too hot)." },
                         {"6","Add pesto and 1/4 cup of pasta water. Toss to coat pasta in pesto, adding more water if required to make pasta silky and saucy, rather than dry and sticky." },
                         {"7","Taste, add more salt and pepper if desired." },
                         {"8","Serve immediately, garnished with fresh parmesan." },

                    },
                    Image = "pasta_pesto.png",
                    Color = new Color(174,188,26),
                    Rating = 3.0
                },
                new()
                {
                    Title = "Gambas Pasta",
                    PrepTime = "20 mins",
                    Category= RecipeCategoryEnum.Meal,
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "4 cups noodles",
                        "1 kg prawns ",
                        "2 tbs butter",
                        "1 tbs olive oil",
                        "1/3 cup garlic",
                        "2 tbs soy sauce",
                        "chili flakes"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","In a large sauté pan on medium heat, place butter and oil and heat until frothy." },
                         {"2","Add garlic and sauté until fragrant. Do not allow to brown." },
                         {"3","Add peeled prawns and cook until slightly pink." },
                         {"4","Add the rest of the ingredients and toss into the prepared pasta. Serve hot." },

                    },
                    Image = "pasta_gambas.png",
                    Color = ColorPalet.Beige,
                    Rating = 3.4
                },
                new()
                {
                    Title = "Cinnamon Rolls",
                    PrepTime = "2 Hours",
                    Category= RecipeCategoryEnum.Desert,
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel orci nisi. Aliquam turpis tellus, pretium placerat varius condimentum, imperdiet sit amet tellus. Nulla vel lacus leo.",
                    Ingredients = new List<string>()
                    {
                        "¾ cup milk",
                        "2 ¼ tbs yeast ",
                        "¼ cup sugar",
                        "1 egg",
                        "2/3 cup sugar ",
                        "¼ cup butte",
                        "1 ½ tbs cinnamon"
                    },
                     Directions = new Dictionary<string, string>()
                    {
                         {"1","Warm milk to around 110 degrees F. I like to do this by placing milk in a microwave safe bowl and microwaving it for 40-45 seconds. It should be like warm bath water." },
                         {"2","Place dough hook on stand mixer and knead dough on medium speed for 8 minutes. Dough should form into a nice ball and be slightly sticky." },
                         {"3","Transfer dough ball to a well-oiled bowl, cover with plastic wrap and a warm towel. Allow dough to rise for 1 hour to 1 ½ hours, or until doubled in size." },
                         {"4","After dough has doubled in size, transfer dough to a well-floured surface and roll out into a 14x9 inch rectangle. Spread softened butter over dough, leaving a ¼ inch margin at the far side of the dough." },
                         {"5","In a small bowl, mix together brown sugar and cinnamon. Use your hands to sprinkle mixture over the buttered dough, then rub the brown sugar mixture into the butter." },
                         {"6","Place cinnamon rolls in a greased 9x9 inch baking pan or round 9 inch cake pan. (I also recommend lining the pan with parchment paper as well, in case any of the filling ends up leaking out.) Cover with plastic wrap and a warm towel and let rise again for 30-45 minutes." },
                         {"7","Preheat oven to 350 degrees F. Remove plastic wrap and towel and bake cinnamon rolls for 20-25 minutes or until just slightly golden brown on the edges. You want to underbake them a little so they stay soft in the middle, that’s why we want them just slightly golden brown. Allow them to cool for 5-10 minutes before frosting. Makes 9 cinnamon rolls." },
                         {"8","To make the frosting: In the bowl of an electric mixer, combine cream cheese, butter, powdered sugar and vanilla extract. Beat until smooth and fluffy. Spread over cinnamon rolls and serve immediately. Enjoy!" },

                    },
                    Image = "cinnamon_roll.png",
                    Color = new Color(142,115,60),
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
                        "1 ingredient",
                        "1/2 ingredient",
                        "3 ingredient",
                        "ingredient",
                        "ingredient",
                        "1 ingredient",
                        "1/2 ingredient"
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
                    Color = new Color(225,107,39),
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
                        "1 ingredient",
                        "1/2 ingredient",
                        "3 ingredient",
                        "ingredient",
                        "ingredient",
                        "1 ingredient",
                        "1/2 ingredient"
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
                    Color = new Color(103,165,50),
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
                        "1 ingredient",
                        "1/2 ingredient",
                        "3 ingredient",
                        "ingredient",
                        "ingredient",
                        "1 ingredient",
                        "1/2 ingredient"
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
                    Color = new Color(220,81,72),
                    Rating = 4.5
                },
            };
    }
}
