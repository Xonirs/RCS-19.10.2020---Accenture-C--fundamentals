using System;

namespace Day16_withoutMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {  80, 10, 40, 50, 60, 80, 111, 233, -5, -12 };
            Console.WriteLine("Here is the numbers array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Let's change some values");
            numbers[0] = 999;
            numbers[4] = 88;
            numbers[7] = 777;
            Console.WriteLine("Array values have been changed");

            Console.WriteLine("Here is the numbers array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Let's change some values, first 3 values should be negative");
            numbers[0] = -55;
            numbers[1] = -33;
            numbers[2] = -44;
            Console.WriteLine("Array values have been changed");

            Console.WriteLine("Here is the numbers array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Let's allow the user to input array values 1,4,5,10.");

            Console.WriteLine("Please input the new value for array element nr.1");
            string newValue1input = Console.ReadLine();
            int newValue1 = int.Parse(newValue1input);
            numbers[0] = newValue1; //GetNewArrayElement();

            Console.WriteLine("Please input the new value for array element nr.4");
            string newValue4input = Console.ReadLine();
            int newValue4 = int.Parse(newValue4input);
            numbers[3] = newValue4;

            Console.WriteLine("Please input the new value for array element nr.5");
            string newValue5input = Console.ReadLine();
            int newValue5 = int.Parse(newValue5input);
            numbers[4] = newValue5;

            Console.WriteLine("Please input the new value for array element nr.10");
            string newValue10input = Console.ReadLine();
            int newValue10 = int.Parse(newValue10input);
            numbers[9] = newValue10;

            Console.WriteLine("Here is the numbers array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
