using System;

namespace OOP.Studies.Polymorphism
{
    public abstract class Employee
    {
        public double Salary { get; set; }

        public virtual string GetDiscount()
        {
            return $"Default discount value $ {Math.Round(Salary * 0.05, 2)}";
        }
    }
}
