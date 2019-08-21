using System;
using System.Collections.Generic;
using KitchenManagement.Staff;
using System.Linq;

namespace KitchenManagement.Kithcen
{
    class Kitchen : IKitchen
    {
        List<KitchenHelper> kitchenHelpers = new List<KitchenHelper>();
        List<LineCook> lineCooks = new List<LineCook>();
        Chef chef = null;

        internal void AddEmployee(Employee employee)
        {
            if (employee is KitchenHelper)
            {
                kitchenHelpers.Add((KitchenHelper)employee);
            }
            else
            {
                if (employee is Chef && this.chef == null)
                {
                    chef = (Chef)employee;
                    chef.Kitchen = this;
                }
                lineCooks.Add((LineCook)employee);
            }
        }

        internal void SimulateKitchen(int days, int meals)
        {
            Enumerable.Range(0, days)
                .ToList()
                .ForEach(day => RunForADay(meals));
        }

        private void RunForADay(int meals)
        {
            Console.WriteLine("------------------\n");

            kitchenHelpers.ForEach(helper => helper.StockWithIngredient());
            HandOutKnifeSet();
            Enumerable.Range(0, meals)
                .ToList()
                .ForEach(meal => lineCooks.ForEach(lineCook => lineCook.DoCooking()));
        }

        private void HandOutKnifeSet()
        {
            Console.WriteLine("------------------\n");

            lineCooks.FindAll(cook => !cook.HasKnifeSet)
                .ToList()
                .ForEach(cook => cook.GetKnifeSet());

            Console.WriteLine("------------------\n");
        }

        public void GetKitchenHelperWithIngredient(Ingredients randomIngredient)
        {
            KitchenHelper helperWithIngredient = kitchenHelpers
                .FindAll(helper => helper.IngredientStock[randomIngredient] > 0)
                .FirstOrDefault();

            if (helperWithIngredient != null)
            {
                helperWithIngredient.GiveChefTheIngredient(randomIngredient);
            }
            else
            {
                kitchenHelpers.ForEach(helper => Console.WriteLine($"{helper.Name} yells: 'We are all out!'"));
            }
        }
    }
}
