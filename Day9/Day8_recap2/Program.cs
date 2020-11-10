using System;

namespace Day8_recap2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finishedAllHomework = true;
            while (finishedAllHomework)
            {
                Console.Write("Did teacher create a new homework task (y/n): ");
                string userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    finishedAllHomework = false;
                }
            }


            string userValue = "";
            while (userValue != "stop")
            {
                userValue = Console.ReadLine();
            }
        }
    }
}