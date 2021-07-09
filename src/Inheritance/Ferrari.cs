namespace OOP.Studies.Inheritance
{
    public class Ferrari : Automobile
    {
        public string Color { get; set; }

        public string LicensePlate { get; set; }

        public override string GetCompleteDescription()
        {
            var completeModel = base.GetCompleteDescription();
            return $"{completeModel} - {Color} - {LicensePlate}";
        }

        // Marcando como selado as subclasses da classe Ferrari não poderão 
        public sealed override string GetSimpleDescription()
        {
            return $"{Manufacturer} - {Model}";
        }
    }
}
