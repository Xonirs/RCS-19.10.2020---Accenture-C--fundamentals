using System;

namespace Day3_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 10;
            int a = 15, b = 10; //this the same thing as 2 the lines above
            
            if (a > b)
            {
                Console.WriteLine("TRUE, a is greater than b!");
            }

            int x = 99, y = 340;
            if (x > y)
            {
                Console.WriteLine("X is greater than Y");
            }
            else
            {
                Console.WriteLine("NONE OF THE ABOVE CONDITIONS WERE TRUE");
            }

            int j = 37, k = 45;
            if (j > k)
            {
                Console.WriteLine("J is greater than K");
            }
            else if (k < 50)
            {
                Console.WriteLine("K is smaller than 50");
            }
            else
            {
                Console.WriteLine("J is smaller than K and K is bigger than 50.");
            }

            Console.WriteLine("END OF CODE");
        }
    }
}
