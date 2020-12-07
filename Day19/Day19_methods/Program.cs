using System;

namespace Day19_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 99, 8, 7, 33, 14, 3 };
            PrintArrayValues(numbers);
            numbers[2] = -8888;
            numbers[3] = 7777;
            PrintArrayValues(numbers);
            string[] relatives = GetSomeNames(3);
            PrintArrayValues(relatives);
        }

        static string[] GetSomeNames(int size)
        {
            string[] names = new string[size];

            for (int i = 0; i < size; i++)
            {
                names[i] = Console.ReadLine();
            }

            return names;
        }
        static void PrintArrayValues(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void PrintArrayValues(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " "); 
            }
            Console.WriteLine();
        }
    }
}
