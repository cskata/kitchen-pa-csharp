using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenManagement.Staff
{
    class Cook : LineCook
    {
        public Cook(string name, DateTime birthDate, double salary) : base(name, birthDate, salary)
        {
        }
        public override void DoCooking()
        {
            Console.WriteLine($"{Name} prepared a meal.");
        }
    }
}
