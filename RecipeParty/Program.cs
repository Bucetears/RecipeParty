using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        List<string> mealOptions = new List<string>();
        mealOptions.Add("Breakfast");
        mealOptions.Add("Dinner");
        mealOptions.Add("Snack");
        mealOptions.Add("Dessert");


    }
}

class Recipe
{
    string name = "";
    bool hasMade = false;
    Dictionary<string, string> ingredients = new Dictionary<string, string>();
    string mealType = "";
    List<string> directions = new List<string>();

    static void getName()
    {
        Console.WriteLine("Enter Recipe Name: ");
        //self.name = Console.ReadLine();
    }
    
}

