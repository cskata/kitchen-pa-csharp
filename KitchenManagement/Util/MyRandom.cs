using KitchenManagement.Kithcen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitchenManagement.Util
{
    static class MyRandom
    {
        readonly static Random RANDOM = new Random();

        public static int GetRandomIndex(int limit)
        {
            return RANDOM.Next(0, limit);
        }

        public static bool GetRandomBoolean()
        {
            return RANDOM.Next(0, 100) < 50;
        }

        public static int GetRandomNumber(int max)
        {
            return RANDOM.Next(0, max) + 1;
        }

        public static Ingredients GetRandomIngredient()
        {
            Ingredients[] ingredients = Enum.GetValues(typeof(Ingredients)).Cast<Ingredients>().ToArray();
            return ingredients[GetRandomIndex(ingredients.Length)];
        }
    }
}
