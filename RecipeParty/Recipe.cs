using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeParty.obj
{
    public class Recipe
    {
        string name;
        bool hadMade;
        public Dictionary<string, string> ingredients = new Dictionary<string, string>();
        public string mealType;
        public List<string> directions = new List<string>();
    }
}