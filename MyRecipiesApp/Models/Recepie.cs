namespace MyRecipiesApp.Models
{
    public class Recepie
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
        public Dictionary<string,string> Directions { get; set; }

        public string Image { get; set; }
        public Color Color { get; set; }
        public double Rating { get; internal set; }
    }
}