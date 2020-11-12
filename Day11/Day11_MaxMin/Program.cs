using System;

namespace Day11_MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define an int array with at least 5 values. Find the max and min values and print them out. 
            //The code must work for any values in the array.

            //Int array definition
            int[] numbers = { 10, 20, 1, 45, 36 };
            //Initial value for the max variable is the first array element
            //Variable max always stores the current max value in the loop
            int max = numbers[0];
            int min = numbers[0];

            //A loop to iterate through all the numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                //Compare if the current array element in the loop is bigger than the existing max value
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                //Compare if the current array element in the loop is smaller than the existing min value
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Max value is : {max}. Min value is : {min}.");
        }
    }
}
