using System;

namespace Day5_typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a bool value (e.g. true, false):");
            string boolInput = Console.ReadLine();
            bool userBool = bool.Parse(boolInput);
            Console.WriteLine($"You input {userBool}");

            Console.WriteLine("Input a double value (e.g. 1.23):");
            string doubleInput = Console.ReadLine();
            double userDouble = double.Parse(doubleInput);
            Console.WriteLine($"You input {userDouble}");
        }
    }
}
