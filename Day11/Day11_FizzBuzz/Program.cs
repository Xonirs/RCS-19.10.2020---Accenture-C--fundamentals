using System;

namespace Day11_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use for loop to print all the numbers from 1 to 21, so the loop executes 21 time.
            //In case the loop iteration count value divides with 3 without remainder then print Fizz, 
            //if the value divides with 5 without remainder, print Buzz.
            //If the loop iteration count value divides with both 3 and 5, then print FizzBuzz.
            //Output should look like this: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz etc. 
            //So the task is to print the numbers from 1 to 21 and instead of some specific numbers we print some text values.

            for (int i = 1; i <= 21; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
