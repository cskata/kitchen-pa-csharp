using KitchenManagement.Kithcen;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using KitchenManagement.Util;

namespace KitchenManagement.Staff
{
    class KitchenHelper : Employee
    {
        const int MAX_INGREDIENT_AMOUNT = 3;

        Dictionary<Ingredients, int> ingredientStock = new Dictionary<Ingredients, int>();
        public Dictionary<Ingredients, int> IngredientStock
        {
            get { return ingredientStock; }
        }

        public KitchenHelper(string name, DateTime birthDate, double salary) : base(name, birthDate, salary)
        {
            Enum.GetValues(typeof(Ingredients))
                .Cast<Ingredients>()
                .ToList()
                .ForEach(ingredient => ingredientStock.Add(ingredient, 0));
        }

        internal void StockWithIngredient()
        {
            ingredientStock.Keys
                .Cast<Ingredients>()
                .ToList()
                .ForEach(key => ingredientStock[key] = MyRandom.GetRandomNumber(MAX_INGREDIENT_AMOUNT));

            Console.WriteLine(
                $"{Name} has Carrot: {ingredientStock[Ingredients.Carrot]}, Meat: {ingredientStock[Ingredients.Meat]}, Potato: {ingredientStock[Ingredients.Potato]}");
        }
        public void GiveChefTheIngredient(Ingredients randomIngredient)

        {
            this.ingredientStock[randomIngredient] = ingredientStock[randomIngredient] - 1;
            Console.WriteLine($"{Name} yeels: 'Here is your bloody {randomIngredient}'");
        }

        public void yellAllOut()
        {
            Console.WriteLine($"{Name} yells: 'We are all out!'");
        }
    }
}
