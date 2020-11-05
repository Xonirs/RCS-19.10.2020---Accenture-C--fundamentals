using System;

namespace Day7_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 7)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine();
            int counter = -10;
            while (counter < 3)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine();
            int counter2 = 100;
            while (counter2 >= 25)
            {
                Console.WriteLine(counter2);
                counter2--;
            }
            Console.WriteLine();

            //bool rainy = true;
            //int counter3 = 0;
            //while (rainy)
            //{
            //    Console.Write(counter3);
            //    counter3++;
            //}

            Console.WriteLine();

            bool dark = true;
            int counter4 = 0;
            while (dark && counter4 < 10)
            {
                Console.Write($"Loop count:{counter4}. Is it still dark (y/n): ");
                string darkInput = Console.ReadLine();
                if (darkInput == "n" || darkInput == "N" || darkInput == "NO" || darkInput == "no")
                {
                    dark = false;
                }

                counter4++;
            }

            Console.WriteLine();

            //break - stops the loop
            int counter5 = 0;
            while (counter5 < 10)
            {
                Console.Write("Do you want to stop: ");
                string stopInput = Console.ReadLine();
                if (stopInput == "stop" || counter5 == 8)
                {
                    break;
                }

                counter5++;
            }
            Console.WriteLine($"Loop has ended, counter: {counter5}");

            Console.WriteLine();

            //continue - skips the rest of the iteration and jumps to next one
            int counter6 = 0;
            while (counter6 < 10)
            {                
                if (counter6 == 5)
                {
                    counter6++;
                    continue;
                }

                Console.WriteLine(counter6);
                counter6++;
            }
        }
    }
}