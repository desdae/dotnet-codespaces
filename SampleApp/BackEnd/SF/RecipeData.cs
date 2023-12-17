namespace SF 
{

    public static class RecipeData
    {
        public static List<Recipe> GetRecipesList()
        {
            return new List<Recipe>() {
                new Recipe {
                    ID = "IronIngot",
                    OutputRatePerMin = 30.0,
                    Components = new List<RecipeComponent> { 
                        new RecipeComponent {
                            ID = "IronOre", 
                            InputRatePerMin = 30.0
                        }
                    }
                },
                new Recipe {
                    ID = "CopperIngot",
                    OutputRatePerMin = 30.0,
                    Components = new List<RecipeComponent> { 
                        new RecipeComponent {
                            ID = "CopperOre", 
                            InputRatePerMin = 30.0
                        }
                    }
                }  
            };
        }
        public static Dictionary<string, Recipe> GetRecipesDict()
        {
            var availableRecipes = new Dictionary<string, Recipe>();
            foreach (var rec in GetRecipesList())
                availableRecipes[rec.ID] = rec;
            return availableRecipes;
        }
    }

}