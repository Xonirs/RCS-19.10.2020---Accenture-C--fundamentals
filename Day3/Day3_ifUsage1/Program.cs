using System;

namespace Day3_ifUsage1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get a number from a user. 
            Console.WriteLine("Please enter a number:");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);

            //If the number is between 0 and 10 then print out “A” and 
            if (10 > number && number > 0)
            {
                Console.WriteLine("A");
            }
            //if the value is larger than 10, then print out “B”.
            else if (number > 10)
            {
                Console.WriteLine("B");
            }
        }
    }
}
