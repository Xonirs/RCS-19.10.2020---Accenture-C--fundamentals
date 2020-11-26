using System;

namespace Day15_methods_vol3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCarInfo("bmw", 2010, 10000.99, false);
            string car1Name = GetCarValue("name");
            int car1Year = int.Parse(GetCarValue("year"));
            double car1Price = double.Parse(GetCarValue("price"));
            bool car1IsElectrical = bool.Parse(GetCarValue("eco friendly value"));
            PrintCarInfo(car1Name, car1Year, car1Price, car1IsElectrical);
        }

        static string GetCarValue(string value)
        {
            Console.WriteLine($"Please input your car's {value}");
            string carValue = Console.ReadLine();
            return carValue;
        }

        static void PrintCarInfo(string name, int year, double price, bool isElectrical)
        {
            Console.WriteLine("Information about your car:");
            Console.WriteLine($"Your car name - {name}.");
            Console.WriteLine($"Your car assembly year - {year}. Which means, your car is {2020 - year} years old.");
            Console.WriteLine($"Your car price - {price}.");

            string electricalMessage = isElectrical ? "Your car is electrical and good for environment." : "Your car uses gas.";
            Console.WriteLine(electricalMessage);
        }

        
    }
}
