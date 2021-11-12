using OOP.Studies.Abstraction;
using OOP.Studies.Composition;
using OOP.Studies.Encapsulation;
using OOP.Studies.Inheritance;
using OOP.Studies.Polymorphism;
using System;

namespace OOP.Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction: ");
            var legalPerson = new LegalPerson();
            Console.WriteLine(legalPerson.ProfitDefaultTax(500, 0.5));
            Console.WriteLine(legalPerson.ProfitSpecialTax(500));

            var physicalPerson = new PhysicalPerson();
            Console.WriteLine(physicalPerson.ProfitDefaultTax(500, 0.5));
            Console.WriteLine(physicalPerson.ProfitSpecialTax(500));

            Console.WriteLine("\nInheritance: ");
            var ferrari = new Ferrari();
            ferrari.Manufacturer = "Ferrari";
            ferrari.Model = "California";
            ferrari.Power = 700;
            ferrari.LicensePlate = "ABC-1234";
            ferrari.Color = "Rosso Corsa";
            var description = ferrari.GetCompleteDescription();
            Console.WriteLine(description);

            Console.WriteLine("\nComposition: ");
            var car = new Car();
            car.Engine.Power = 350;
            car.DoorLeft.Manufacturer = "ABC Company";
            car.DoorRight.Manufacturer = "ABC Company";
            car.TireFrontLeft.Manufacturer = "Pirelli";
            car.TireFrontRight.Manufacturer = "Pirelli";
            car.TireBackLeft.Manufacturer = "Pirelli";
            car.TireBackLeft.Manufacturer = "Pirelli";
            Console.WriteLine(car.GetCompleteDescription());

            Console.WriteLine("\nEncapsulation: ");
            var repository = new Repository();
            repository.ExecuteComand("command...");

            Console.WriteLine("\nPolymorphism: ");
            var intern = new Intern();
            intern.Salary = 1000;
            Console.WriteLine(intern.GetDiscount());

            var seller = new Seller();
            seller.Salary = 2500;
            Console.WriteLine(seller.GetDiscount());

            var manager = new Manager();
            manager.Salary = 9000;
            Console.WriteLine(manager.GetDiscount());

            Console.ReadKey();
        }
    }
}
