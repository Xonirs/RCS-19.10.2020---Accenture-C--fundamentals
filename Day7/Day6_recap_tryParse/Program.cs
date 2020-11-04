using System;

namespace Day6_recap_tryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your age: ");
            string userInput = Console.ReadLine();

            int age;
            bool isUserInputANumber = int.TryParse(userInput, out age);
            if (isUserInputANumber)
            {
                Console.WriteLine($"Your age is {age} and you were born in {2020 - age}!");
            }
            else 
            {
                Console.WriteLine($"Error, can't convert '{userInput}' to a number!");
            }

            
        }
    }
}
