using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenManagement.Staff
{
    abstract class Employee
    {
        internal string Name;
        private readonly DateTime birthDate;
        private double salary;
        private double taxRate = 0.99;

        protected Employee(string name, DateTime birthDate, double salary)
        {
            Name = name;
            this.birthDate = birthDate;
            this.salary = salary;
            CreateTaxReport();
        }

        protected void CreateTaxReport()
        {
            double payableTax = salary * taxRate;
            Console.WriteLine($"{Name}'s payable tax is {payableTax}.");
        }
    }
}
