using System;

namespace Day6_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            while (number > 8)
            {
                //do stuff   
                Console.WriteLine(number);

                //number = number - 1; 
                number--;
            }
            Console.WriteLine();

            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine();

            string text = "";
            while (text != "tatatata")
            {
                Console.WriteLine(text);
                text = text + "ta";
            }


        }
    }
}
