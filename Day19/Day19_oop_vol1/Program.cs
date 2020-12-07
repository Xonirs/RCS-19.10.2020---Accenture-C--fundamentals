using System;

namespace Day19_oop_vol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 32;
            person.Name = "Willy Nemesis";

            Person personNew = new Person()
            {
                Age = 21,
                Name = "Nelly Jukhmo"
            };

            Garage garage = new Garage();
            garage.Name = "OldTown Shop";
            garage.Address = "G street nr.1";
            garage.Owner = person;

            Garage garageNewWay = new Garage();
            garageNewWay.Name = "New way ROCKZ";
            garageNewWay.Address = "P street nr.37";
            garageNewWay.Owner = new Person()
            {
                Age = 57,
                Name = "Sally Potrusko"
            };

            var garageGold = new Garage()
            {
                Name = "GOLD STYLE GARAGE",
                Address = "Global square",
                Owner = personNew,
                MainCar = new Car()
                {
                    Manufacturer = "BMW",
                    Year = 2040,
                    Model = "M19",
                    Owner = garageNewWay.Owner
                }
            };

            Console.WriteLine($"Garage name is {garageGold.Name}");
            Console.WriteLine($"Garage owner's name is {garageGold.Owner.Name}");
            Console.WriteLine($"Garage main car's model is {garageGold.MainCar.Model}");
            Console.WriteLine($"Garage main car's owner's name is {garageGold.MainCar.Owner.Name}");


        }
    }
}
