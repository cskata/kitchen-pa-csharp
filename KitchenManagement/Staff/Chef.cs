using KitchenManagement.Kithcen;
using KitchenManagement.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenManagement.Staff
{
    class Chef : LineCook
    {
        public IKitchen Kitchen { get; set; }

        public Chef(string name, DateTime birthDate, double salary) : base(name, birthDate, salary)
        {
        }

        public override void DoCooking()
        {
            Console.WriteLine($"{Name} yells: 'HURR DURR DURR!'");
            if (NeedsIngredient())
            {
                Ingredients randomIngredient = MyRandom.GetRandomIngredient();
                Console.WriteLine($"{Name} yells: 'I need a bloody {randomIngredient}!'");
                Kitchen.GetKitchenHelperWithIngredient(randomIngredient);
            }

        }
        private bool NeedsIngredient()
        {
            return MyRandom.GetRandomBoolean();
        }
    }
}
