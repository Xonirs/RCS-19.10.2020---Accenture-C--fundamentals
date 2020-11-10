using System;

namespace Day9_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);
            Console.WriteLine();

            //find out with how many tries user can guess your secret word
            string userInput;
            string secretWord = "election";
            int n = 0;
            do
            {
                Console.Write("Please input your guess of the secret word game: ");
                userInput = Console.ReadLine();
                n++;
            } while (userInput != secretWord);
            Console.WriteLine($"You guessed the secret word {secretWord} in {n} tries!");

        }
    }
}
