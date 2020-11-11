using System;

namespace Day10_InputOutputLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number N.
            Console.WriteLine("How many relatives do you have:");
            //parsing the value which user will give into console
            int relativeCount = int.Parse(Console.ReadLine());

            //Define a string array with the size of N.
            string[] relatives = new string[relativeCount];

            //Then create a loop, which will ask the user to input your relative names for N times and the names are saved in the array.
            for (int i = 0; i < relativeCount; i++)
            {
                Console.WriteLine($"What is the name of your nr.{i+1} relative?");
                relatives[i] = Console.ReadLine();
            }

            //Then in a NEW loop look at all the names and print those whose length is greater than 5.
            Console.WriteLine("Here are all the relatives with 'long' names:");
            for (int i = 0; i < relativeCount; i++)
            {
                if (relatives[i].Length > 5)
                {
                    Console.WriteLine(relatives[i]);
                }
            }
        }
    }
}
