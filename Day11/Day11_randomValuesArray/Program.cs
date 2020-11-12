using System;

namespace Day11_randomValuesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define an int array with size of 10. Assign all the values with Random values. In a new loop, print all the values.
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();
                int a = random.Next(100); //random values till 100
                numbers[i] = a;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
