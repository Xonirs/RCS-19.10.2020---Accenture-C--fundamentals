using System;

namespace Day15_methods_vol6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(12.23);
            Console.WriteLine(100);
            Console.WriteLine(false);
            Console.WriteLine("adasdasdasd");

            AnalyzeNumber(150);
            AnalyzeNumber(90.51);

            string userNameSurname1 = GetNameSurname();
            Console.WriteLine($"Your full name is {userNameSurname1}");
            string name = "John";
            string userNameSurname2 = GetNameSurname(name);
            Console.WriteLine($"Your full name is {userNameSurname2}");
        }

        static string GetNameSurname()
        {
            Console.WriteLine("What is your name and surname?");
            string userInput = Console.ReadLine();
            return userInput;
        }
        static string GetNameSurname(string name)
        {
            Console.WriteLine("What is your surname?");
            string userSurname = Console.ReadLine();
            return name + " " + userSurname;
        }

        static void AnalyzeNumber(int number)
        {
            Console.WriteLine($"This is an int number - {number}");
            if (number > 100)
            {
                Console.WriteLine("Number is above 100");
            }
        }

        static void AnalyzeNumber(double number)
        {
            Console.WriteLine($"This is a double number - {number}");
            if (number > 100)
            {
                Console.WriteLine("Number is above 100");
            }
            Console.WriteLine($"This number rounded up is {Math.Round(number, MidpointRounding.AwayFromZero)}");
        }
    }
}
