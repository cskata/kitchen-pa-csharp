using System;
using System.Collections.Generic;
using System.Text;
using KitchenManagement.Util;

namespace KitchenManagement.Staff
{
    abstract class LineCook : Employee
    {
        bool hasKnifeSet = false;
        public bool HasKnifeSet
        {
            get { return hasKnifeSet; }
        }
        public LineCook(string name, DateTime birthDate, double salary) : base(name, birthDate, salary)
        {
        }

        public abstract void DoCooking();

        public void GetKnifeSet()
        {
            if (MyRandom.GetRandomBoolean())
            {
                hasKnifeSet = true;
                Console.WriteLine($"{Name} yells: 'Got mah knives!'");
            }
        }
    }
}
