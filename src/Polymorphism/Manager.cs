using System;

namespace OOP.Studies.Polymorphism
{
    public class Manager : Employee
    {
        public override string GetDiscount()
        {
            return $"Manager discount value $ {Math.Round(Salary * 0.01, 2)}";
        }
    }
}
