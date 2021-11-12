using System;

namespace OOP.Studies.Abstraction
{
    public class PhysicalPerson : DefaultPerson
    {
        public override string ProfitSpecialTax(double value)
        {
            return $"PhysicalPerson Profits: ${value * 0.1}";
        }
    }
}
