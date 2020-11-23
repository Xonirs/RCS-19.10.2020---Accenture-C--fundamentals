using System;

namespace Day14_methods_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            string favCar = GetFavoriteCar();
            Console.WriteLine($"Your favorite car is {favCar} and it has {favCar.Length} characters!");

            int testNumber = 39;
            int magic1 = GetMagicNumber(testNumber);
            Console.WriteLine($"Magic number from {testNumber} is {magic1}");
        }

        public static string GetFavoriteCar()
        {
            Console.WriteLine("What is your favorite car?");
            string userCar = Console.ReadLine();
            return userCar;
        }

        public static int GetMagicNumber(int number)
        {
            int magic = number * 37 - 103;

            if (magic % 2 == 0)
            {
                magic += 456;
            }

            magic -= 333;

            for (int i = 0; i < number; i++)
            {
                magic += i;
            }

            return magic;
        }
    }
}
