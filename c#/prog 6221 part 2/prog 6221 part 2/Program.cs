using System;
using System.Collections.Generic;
using System.Linq;

class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }

    public Recipe(string name)
    {
        Name = name;
        Ingredients = new List<Ingredient>();
    }

    public int GetTotalCalories()
    {
        return Ingredients.Sum(ingredient => ingredient.Calories);
    }

    public void AddIngredient(string name, int calories, string foodGroup)
    {
        Ingredients.Add(new Ingredient(name, calories, foodGroup));
    }
}

class Ingredient
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public string FoodGroup { get; set; }

    public Ingredient(string name, int calories, string foodGroup)
    {
        Name = name;
        Calories = calories;
        FoodGroup = foodGroup;
    }
}

class Program
{
    static List<Recipe> recipes = new List<Recipe>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add a recipe");
            Console.WriteLine("2. Display all recipes");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddRecipe();
                    break;
                case 2:
                    DisplayRecipes();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddRecipe()
    {
        Console.WriteLine("Enter the name of the recipe:");
        string recipeName = Console.ReadLine();

        Recipe recipe = new Recipe(recipeName);

        while (true)
        {
            Console.WriteLine("Enter the name of the ingredient (or type 'done' to finish adding ingredients):");
            string ingredientName = Console.ReadLine();

            if (ingredientName.ToLower() == "done")
                break;

            Console.WriteLine("Enter the number of calories:");
            int calories = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the food group:");
            string foodGroup = Console.ReadLine();

            recipe.AddIngredient(ingredientName, calories, foodGroup);
        }

        recipes.Add(recipe);

        Console.WriteLine("Recipe added successfully!");
    }

    static void DisplayRecipes()
    {
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes found.");
            return;
        }

        recipes.Sort((r1, r2) => r1.Name.CompareTo(r2.Name));

        Console.WriteLine("Select a recipe to display:");

        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine("{i + 1}. {recipes[i].Name}");
        }

        int choice = int.Parse(Console.ReadLine());

        if (choice >= 1 && choice <= recipes.Count)
        {
            Recipe selectedRecipe = recipes[choice - 1];
            DisplayRecipe(selectedRecipe);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    static void DisplayRecipe(Recipe recipe)
    {
        Console.WriteLine("Recipe: {recipe.Name}");

        foreach (Ingredient ingredient in recipe.Ingredients)
        {
            Console.WriteLine("- Ingredient: {ingredient.Name}");
            Console.WriteLine("  Calories: {ingredient.Calories}");
            Console.WriteLine("  Food Group: {ingredient.FoodGroup}");
        }

        int totalCalories = recipe.GetTotalCalories();
        Console.WriteLine("Total Calories: {totalCalories}");

        if (totalCalories > 300)
        {
            Console.WriteLine("This recipe exceeds 300 calories.");
        }
    }
}