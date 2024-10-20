using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeParty
{
    public class Recipe
    {
        public string name;
        public string mealType;
        public bool haveMade;
        public Dictionary<string, string> ingredients;
        public List<string> directions;
        

        public Recipe()
        {
            name = getRecipeName();
            mealType = getMealType();
            haveMade = haveMadeBefore();
        }

        public static void Main(){

        }
        public static string getRecipeName()
        {
            Console.WriteLine("Enter the Recipe Name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static string getMealType()
        {
            List<string> mealOptions = new List<string>();
            mealOptions.Add("Breakfast");
            mealOptions.Add("Dinner");
            mealOptions.Add("Snack");
            mealOptions.Add("Dessert");
            int length = mealOptions.Count();
            int choice = 0;
            Console.WriteLine("Which Meal Type would you like?\n");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i.ToString(), ": ", mealOptions[i]);
            }
            Console.WriteLine("Enter the number of the option you would like: ");
            choice = int.Parse(Console.ReadLine());
            string mealType = mealOptions[choice];
            return mealType;

        }
        
        public static bool haveMadeBefore()
        {
            bool haveMade;
            Console.WriteLine("Have you made this meal before? (y/n) ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                haveMade = true;
            }
            else{
                haveMade = false;
            }
            return haveMade;

        }

        public static Dictionary<string, string> getIngredients()
        {
            Dictionary<string, string> ingredients = new Dictionary<string, string>();
            bool add_ingredients = true;
            string ingredientName;
            string ingredientAmount;
            while (add_ingredients){
                Console.WriteLine("Type the ingredient name: ");
                ingredientName = Console.ReadLine();
                Console.WriteLine("Type the amount needed: ");
                ingredientAmount = Console.ReadLine();
                ingredients.Add(new KeyValuePair<string, string>(ingredientName, ingredientAmount));
            }
            return ingredients;
        }

    }
}