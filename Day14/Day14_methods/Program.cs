using System;

namespace Day14_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing method PrintTopic for the first time:");
            PrintTopic();
            Console.WriteLine("Executing method PrintTopic for the second time:");
            PrintTopic();

            PrintName("Bungldeshjuakal");
            string user = "Peter John George";
            PrintName(user);
            string anotherInput = Console.ReadLine();
            PrintName(anotherInput);
            PrintSum(321, 123);
            PrintNameSalary(user, 444.677, 2020);
        }

        public static void PrintTopic()
        {
            Console.WriteLine("Today we are building our first game - TicTacToe!");
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Your name is {name} and it has {name.Length} characters!");
        }

        public static void PrintSum(int a, int b)
        {
            Console.WriteLine($"a:{a}, b:{b}, sum:{a + b}");
        }

        public static void PrintNameSalary(string name, double salary, int year)
        {
            Console.WriteLine($"Name:{name}, salary:{salary}, year:{year}");
        }
    }
}
