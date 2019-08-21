using System;
using KitchenManagement.Kithcen;
using KitchenManagement.Staff;

namespace KitchenManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen Kitchen = new Kitchen();
            InitKitchenStaff(Kitchen);
            Kitchen.SimulateKitchen(5, 10);
        }

        private static void InitKitchenStaff(Kitchen kitchen)
        {
            kitchen.AddEmployee(new KitchenHelper("Ted", new DateTime(1990, 08, 22), 5000));
            kitchen.AddEmployee(new KitchenHelper("Marshall", new DateTime(1990, 08, 22), 5000));
            kitchen.AddEmployee(new Chef("Lily", new DateTime(1990, 08, 22), 20000));
            kitchen.AddEmployee(new Cook("Barney", new DateTime(1990, 08, 22), 10000));
            kitchen.AddEmployee(new Cook("Robin", new DateTime(1990, 08, 22), 10000));
        }
    }
}
