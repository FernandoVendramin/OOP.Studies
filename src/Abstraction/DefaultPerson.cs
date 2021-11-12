namespace OOP.Studies.Abstraction
{
    public abstract class DefaultPerson
    {
        public abstract string ProfitSpecialTax(double value);

        public string ProfitDefaultTax(double value, double tax)
        {
            return $"DefaultPerson Profits: ${value * tax}";
        }
    }
}
