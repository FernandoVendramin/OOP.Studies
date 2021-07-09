namespace OOP.Studies.Inheritance
{
    public abstract class Automobile
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public double Power { get; set; }

        // Como este método é abstrato, ele se torna obrigatório na subclasse
        public abstract string GetSimpleDescription();

        // Como este método é virtual, ele se torna opcional na subclasse
        public virtual string GetCompleteDescription()
        {
            return $"{Manufacturer} - {Model} - {Power}cv";
        }
    }
}
