namespace OOP.Studies.Abstraction
{
    public class LegalPerson : DefaultPerson
    {
        public override string ProfitSpecialTax(double value)
        {
            return $"LegalPerson Profits: ${value * 0.2}";
        }
    }
}
