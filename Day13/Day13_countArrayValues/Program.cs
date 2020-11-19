using System;

namespace Day13_countArrayValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an int array { 1, 10, 4, 68, 10, 54, 78, 10, 98}. Count how many times there is a value 10 in the array.

            //Defining an int array
            int[] numbers = { 1, 10, 4, 68, 10, 54, 78, 10, 98 };
            //Defining counter variable
            int counter = 0;

            //Looking at every array element
            for (int i = 0; i < numbers.Length; i++)
            {
                //Checking if the array element equals to 10
                if (numbers[i] == 10)
                {
                    //If equals to 10, increase counter  
                    counter++; //counter = counter + 1;
                    Console.WriteLine($"Counting in process: {counter}");
                }
            }

            //Print the count
            Console.WriteLine($"In this array, we have {counter} values of '10'.");
        }
    }
}
