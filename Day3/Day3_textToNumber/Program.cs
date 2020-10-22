using System;

namespace Day3_textToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your age:");
            string ageInput = Console.ReadLine();

            //1st way -> int.Parse
            int age = int.Parse(ageInput);
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"You were born in {2020 - age}");
            Console.WriteLine($"In 50 years you will be {age + 50}");

            //2nd way -> Convert.ToInt32
            int age2 = Convert.ToInt32(ageInput);
            Console.WriteLine($"Your age is {age2}");

        }
    }
}
