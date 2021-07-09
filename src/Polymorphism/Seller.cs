using System;

namespace OOP.Studies.Polymorphism
{
    public class Seller : Employee
    {
        public override string GetDiscount()
        {
            return $"Seller discount value $ {Math.Round(Salary * 0.02, 2)}";
        }
    }
}
