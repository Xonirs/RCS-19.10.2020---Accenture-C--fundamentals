using System;

namespace Day9_array_break
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an int array of values 1,1,1,0,1,1,1, 1. 
            //Print all the values until you find 0, once 0 is found, exit the loop. Use break;
            int[] numbers = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            int counter = 0;
            while (counter < numbers.Length)
            {
                if (numbers[counter] == 0)
                {
                    break;
                }

                Console.WriteLine(numbers[counter]);
                counter++; //this ++ is needed to prepare for NEXT iteration
            }
            Console.WriteLine("END OF LOOP");
        }
    }
}
