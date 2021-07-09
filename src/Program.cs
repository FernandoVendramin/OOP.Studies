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
            Console.WriteLine("Inheritance: ");
            var ferrari = new Ferrari();
            ferrari.Manufacturer = "Ferrari";
            ferrari.Model = "California";
            ferrari.Power = 700;
            ferrari.LicensePlate = "ABC-1234";
            ferrari.Color = "Rosso Corsa";
            var description = ferrari.GetCompleteDescription();
            Console.WriteLine(description);

            Console.WriteLine("Composition: ");
            var car = new Car();
            car.Engine.Power = 350;
            car.DoorLeft.Manufacturer = "ABC Company";
            car.DoorRight.Manufacturer = "ABC Company";
            car.TireFrontLeft.Manufacturer = "Pirelli";
            car.TireFrontRight.Manufacturer = "Pirelli";
            car.TireBackLeft.Manufacturer = "Pirelli";
            car.TireBackLeft.Manufacturer = "Pirelli";
            Console.WriteLine(car.GetCompleteDescription());

            Console.WriteLine("Encapsulation: ");
            var repository = new Repository();
            repository.ExecuteComand("command...");

            Console.WriteLine("Polymorphism: ");
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
