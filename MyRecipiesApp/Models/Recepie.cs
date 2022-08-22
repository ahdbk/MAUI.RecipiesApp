namespace MyRecipiesApp.Models
{
    public class Recepie
    {
        public string Title { get; set; }
        public string PrepTime { get; set; }
        public string Description { get; set; }
        public RecipeCategoryEnum Category { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
        public Dictionary<string,string> Directions { get; set; }

        public string Image { get; set; }
        public Color Color { get; set; }
        public double Rating { get; internal set; }
        public bool IsCocktail => this.Category == RecipeCategoryEnum.Cocktail;
    }
}