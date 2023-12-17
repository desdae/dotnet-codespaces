namespace SF
{
    public class Recipe
    {
        public string ID {get;set;}
        public double OutputRatePerMin { get; set;}
        public List<RecipeComponent> Components {get; set;}
    }
}