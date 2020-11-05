using System;

namespace Day8_rainbow_vol1
{
    class Program
    {
        static void Main(string[] args)
        {
            //counter for the loop
            int n = 0;
            //LARGE loop condition
            while (n < 1000000)
            {
                //Creating an object which will generate random numbers
                Random rand = new Random();
                //generating random numbers from 1(or 0) till 15
                int randomNumber = rand.Next(15);
                //converting the random number to an enum
                ConsoleColor color = (ConsoleColor)randomNumber;
                //changing console text color
                Console.ForegroundColor = color;

                ConsoleColor tempColor = ConsoleColor.Green;

                //for BACKGROUND color
                //randomNumber = rand.Next(15);
                //color = (ConsoleColor)randomNumber;
                //Console.BackgroundColor = color;


                //printing a with a Console.Write, thus not moving to the next line
                Console.Write("a");
                //increasing the counter
                n++;
            }
        }
    }
}
