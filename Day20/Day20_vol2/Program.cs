using System;

namespace Day20_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House();
            House house2 = new House("BigHouse", "Garden street 5");
            House house3 = new House("SmallHouse", "Riverview street 10");

            //house1.Count = 5; //will not work, Count can't be accessed via an object
            //Console.WriteLine(house2.Count); //will not work, Count can't be accessed via an object

            //by writing class + ".", you can access static members
            Console.WriteLine($"Currently we have created {House.Count} houses");
            Console.WriteLine("Creating few more houses");
            House house4 = new House();
            House house5 = new House();
            House house6 = new House();
            House house7 = new House();

            Console.WriteLine($"Currently we have created {House.Count} houses");

            //Console.WriteLine($"House1 city is {house1.City}"); //will not work, City is static
            Console.WriteLine($"House1 city is {House.City}"); //will not work, City is static

            House.PrintSomething();

            //....
            //creating million houses
            //....

            House.PrintSomething();
            Console.WriteLine();

            //Calculator calc = new Calculator();
            //int result = calc.Sum(10, 24);

            int result = Calculator.Sum(10, 24);


            int maxValue = Int32.MaxValue;
            int minValue = Int32.MinValue;

            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.WriteLine(Calculator.Sum(minValue, 23523523));
        }
    }
}
