namespace MyRecipiesApp.Services
{
    internal class RecipesService
    {
        internal IEnumerable<RecipeCategory> GetRecipeCategories() => new List<RecipeCategory>
        {
            new() {Label = "Meal", Value = RecipeCategoryEnum.Meal},
            new() {Label = "Salad", Value = RecipeCategoryEnum.Salad},
            new() {Label = "Cocktel", Value = RecipeCategoryEnum.Cocktail},
            new() {Label = "Desert", Value = RecipeCategoryEnum.Desert},
        };
    }
}
