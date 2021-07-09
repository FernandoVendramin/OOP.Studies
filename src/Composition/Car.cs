namespace OOP.Studies.Composition
{
    public class Car
    {
        public Engine Engine = new Engine();

        public Door DoorLeft = new Door();
        public Door DoorRight = new Door();

        public Tire TireFrontLeft = new Tire();
        public Tire TireFrontRight = new Tire();
        public Tire TireBackLeft = new Tire();
        public Tire TireBackRight = new Tire();

        public string GetCompleteDescription()
        {
            var engine = $"Engine Power: {Engine.Power}";
            var doors = $"Doors: L {DoorLeft.Manufacturer}, R {DoorRight.Manufacturer}";
            var tiresFront = $"Tires Front: L {TireFrontLeft.Manufacturer}, R {TireFrontRight.Manufacturer}";
            var tiresBack = $"Tires Back: L {TireBackLeft.Manufacturer}, R {TireBackRight.Manufacturer}";
            return $"{engine} - {doors} - {tiresFront} - {tiresBack}";
        }
    }
}
