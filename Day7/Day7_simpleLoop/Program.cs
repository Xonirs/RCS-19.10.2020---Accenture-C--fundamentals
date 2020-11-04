using System;

namespace Day7_simpleLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program where the user enters number N.             
            Console.WriteLine("Please enter a number N:");
            string nInput = Console.ReadLine();
            int n = int.Parse(nInput);
            int counter = 1;

            //Output all the numbers from 1 to N 
            while (counter <= n)
            {
                //except the number 5 and number 10.
                if (counter != 5 && counter != 10)
                {
                    Console.WriteLine(counter); 
                }
                counter++;
            }
        }
    }
}
