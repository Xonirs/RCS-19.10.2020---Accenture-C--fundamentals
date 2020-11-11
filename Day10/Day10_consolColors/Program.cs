using System;

namespace Day10_consolColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //to change text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello World!");

            //reset colors
            Console.ResetColor();
            Console.WriteLine("Hello World!");

            //to change background color
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hello World!");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!");
        }
    }
}
