using System;

namespace Day8_rainbow_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int waveWidth = 20;               
            int wavePositionCounter = 0;
            int n = 0;
            bool goForward = true;
            while (n < 1000000)
            {
                if (wavePositionCounter == waveWidth)
                {
                    goForward = false;
                }
                else if (wavePositionCounter == 0)
                {
                    goForward = true;
                }

                for (int i = 0; i < waveWidth; i++)
                {
                    if (i == wavePositionCounter)
                    {
                        Random rand = new Random();
                        int randomNumber = rand.Next(15);
                        var color = (ConsoleColor)randomNumber;
                        Console.ForegroundColor = color;
                        Console.Write("a");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                if (goForward)
                {
                    wavePositionCounter++;
                }
                else
                {
                    wavePositionCounter--;
                }

                Console.WriteLine();
                n++;

                //Freezes the program for 10 miliseconds, so that the output is not so fast
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
