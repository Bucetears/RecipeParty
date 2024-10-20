using System;
using System.Collections;
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
            this.name = "No Name";
            this.mealType = "No Type";
            this.haveMade = false;
            this.ingredients = new Dictionary<string, string>();
            this.directions = new List<string>();
        }

        public void starter(){
            this.name = getRecipeName();
            this.mealType = getMealType();
            this.haveMade = haveMadeBefore();
            this.ingredients = getIngredients();
            this.directions = getDirections();
        }
        public void editRecipe(){
            string choice;
            bool continueEdit = true;
            Console.WriteLine("Would you like to edit the recipe? (y/n) ");
            choice = Console.ReadLine();
            if (choice == "y"){
                int option;
                while(continueEdit){
                    Console.WriteLine("What would you like to edit?\n");
                    Console.WriteLine("0. Recipe Name \n1. Meal Type\n2. Have Made Before\n3.Ingredients\n4.Directions\n5.Nothing\n");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 0:
                        this.name = getRecipeName();
                        break;
                        case 1:
                        this.mealType = getMealType();
                        break;
                        case 2:
                        this.haveMade = haveMadeBefore();
                        break;
                        case 3:
                        this.ingredients = getIngredients();
                        break;
                        case 4:
                        this.directions = getDirections();
                        break;
                        case 5:
                        continueEdit = false;
                        break;
                    }
                }
            }
            
        }

        public void viewRecipe(){
            Console.WriteLine(this.name, "\n Meal Type: ", this.mealType);
            if (this.haveMade)
            {
                Console.WriteLine("Made Before: Yes!");
            }
            else {
                Console.WriteLine("Made Before: No!");
            }
            Console.WriteLine("Ingredients: ");
            foreach(var thing in this.ingredients){
                Console.WriteLine(thing.Key);
            }
            foreach (string step in this.directions){
                Console.WriteLine(step);
            }
        }
        public void viewRecipeName(){
            Console.WriteLine(this.name);
        }
        public static string getRecipeName()
        {
            Console.WriteLine("Enter the Recipe Name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static string getMealType()
        {
            string mealType = "No meal Type";
            int choice = 0;
            Console.WriteLine("Which Meal Type would you like?\n");
            Console.WriteLine("0. Breakfast \n1. Snack\n2. Dinner\n3.Dessert");
            Console.WriteLine("Enter the number of the option you would like: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                mealType = "Breakfast";
                break;
                case 1:
                mealType = "Snack";
                break;
                case 2:
                mealType = "Dinner";
                break;
                case 3:
                mealType = "Dessert";
                break;
            }
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
            string option;
            while (add_ingredients){
                Console.WriteLine("Type the ingredient name: ");
                ingredientName = Console.ReadLine();
                Console.WriteLine("Type the amount needed: ");
                ingredientAmount = Console.ReadLine();
                ingredients.Add(ingredientName, ingredientAmount);
                Console.WriteLine("Add more ingredients? (y/n) ");
                option = Console.ReadLine();
                if (option == "n"){
                    add_ingredients = false;
                }
            }
            return ingredients;
        }

        public static List<string> getDirections()
        {
            List<string> directions = new List<string>();
            bool add_steps = true;
            string option;
            while (add_steps){
                Console.WriteLine("Type step: ");
                directions.Add(Console.ReadLine());
                Console.WriteLine("Add another step? (y/n) ");
                option = Console.ReadLine();
                if (option == "n"){
                    add_steps = false;
                }
            }
            return directions;
        }
        
    }
}