using System;

namespace Day3_ifOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;

            if (age == 17)
            {
                Console.WriteLine("You will be allowed to vote next year!");
            }
            else if (age != 10)
            {
                Console.WriteLine("You are NOT 10 years old");
            }
            else
            {
                Console.WriteLine($"Your age is {age}");
            }

            int number = 7;
            string name = "John";
            if (number > 5 && name == "John") 
            {
                //will execute, because both conditions are true
                Console.WriteLine("X");
            }

            if (number <= 5 && name == "John")
            {
                //will not execute, because BOTH conditions are NOT true
                Console.WriteLine("Y");
            }

            if (number <= 5 || name == "John")
            {
                //will execute, because at least ONE condition is true
                Console.WriteLine("Z");
            }
        }
    }
}
