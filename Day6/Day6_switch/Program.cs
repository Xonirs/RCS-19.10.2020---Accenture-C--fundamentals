using System;

namespace Day6_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            switch (number)
            {
                case 1:
                    //leaving empty for now
                    break;
                case 2:
                    Console.WriteLine("That's my favorite number - 2!");
                    break;
                case 3:
                    Console.WriteLine("My daughter's age is 3!");
                    break;
                case 10:
                    Console.WriteLine("I have 10 boardgames.");
                    break;
                case 100:
                    Console.WriteLine("Studying at 100% percent!");
                    break;
                default:
                    Console.WriteLine($"Default case, number - {number}");
                    break;
            }

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            switch (name)
            {
                case "Bob":
                    Console.WriteLine("Bob, is my brother");
                    break;
                case "Ann":
                    Console.WriteLine("Ann is my teacher");
                    break;
                case "Mary":
                    Console.WriteLine("Mary is my best friend!");
                    break;
                default:
                    Console.WriteLine("Sorry, we don't recognize you!");
                    break;
            }

            //...

            Console.WriteLine("END OF CODE");
        }
    }
}
