using System;

namespace Day3_IfUsage2
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have 30 euro in our bank account. Ask the user how much money would he like to take. 
            //Depending on the answer, tell the user appropriate answer – print it in Console screen.
            int bankBalance = 30;
            Console.Write("How much money would you like to take out? ");
            string inputAmount = Console.ReadLine();
            int amount = int.Parse(inputAmount);

            if (amount > bankBalance)
            {
                Console.WriteLine("You don't have that much money!");
            }
            else if (amount < 0)
            {
                Console.WriteLine("You can't enter a negative number!");
            }
            else
            {
                Console.WriteLine($"Here you go, your {amount} euros!");
            }
        }
    }
}
