using System;

namespace Day22_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App is starting");
            int[] myFavNumber = { 23, 44, 51 };
            for (int i = 0; i < myFavNumber.Length; i++)
            {
                int res = GetMagicNumber(myFavNumber[i]);
                Console.WriteLine($"The magic number from {myFavNumber[i]} is {res}");
            }
            Console.WriteLine("App is ending!");
        }

        static int GetMagicNumber(int number)
        {
            int result = number - 6;

            result += number * 7;

            if (number % 2 == 0)
            {
                result *= 37 + number;
            }
            else
            {
                result = GetZombieNumber(result);
                result -= 50;
            }

            return result;
        }

        static int GetZombieNumber(int number)
        {
            int zombie = number - 30;
            zombie *= -17;
            return zombie;
        }
    }
}
