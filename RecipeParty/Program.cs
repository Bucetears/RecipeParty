using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Numerics;
using RecipeParty;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        int choice;
        bool continueMenu = true;
        int index;
        Console.WriteLine("Welcome to Recipe Party! Let's put in a recipe!");
        Recipe testRecipe = new Recipe();
        testRecipe.name = "Water";
        testRecipe.haveMade = true;
        testRecipe.mealType = "Snack";
        testRecipe.ingredients.Add("water", "1 cup");
        testRecipe.directions.Add("Put water under tap");
        Recipe[] recipeList = [testRecipe];
        recipeList = recipeList.Concat(new Recipe[] {testRecipe}).ToArray();
        Console.WriteLine(recipeList.Count().ToString());
        while(continueMenu){
            Console.WriteLine("Welcome to the Recipe Party!\nChoose what you would like to do below.");
            Console.WriteLine("1.Add Recipe\n2.View Recipe\n3.Edit Recipe\n4.Exit");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                recipeList = recipeList.Concat(new Recipe[] {addRecipe()}).ToArray();
                break;
                case 2:
                index = findRecipe(recipeList);
                viewRecipe(recipeList[index]);
                break;
                case 3:
                index = findRecipe(recipeList);
                recipeList[index] = editRecipe(recipeList[index]);
                break;
                case 4:
                continueMenu = false;
                break;
            }
    }

        Recipe addRecipe()
        {
            Recipe recipe1 = new Recipe();
            recipe1.starter();
            return recipe1;
        }

        int findRecipe(Recipe[] recipeList){
            int index = 0;
            int counter = 0;
            int length = recipeList.Count();
            Console.WriteLine("-------------------------------------");
            foreach(Recipe recipe1 in recipeList){
                Console.WriteLine(counter.ToString());
                recipe1.viewRecipeName();
                counter++;
            }
            Console.WriteLine("Enter the number next to the recipe you want to use: ");
            index = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            return index;
        }

        void viewRecipe(Recipe recipe){
            recipe.viewRecipe();
            Console.WriteLine("-------------------------------------");
        }

        Recipe editRecipe(Recipe recipe){
            recipe.editRecipe();
            Console.WriteLine("-------------------------------------");
            return recipe;
        }
    }
}


