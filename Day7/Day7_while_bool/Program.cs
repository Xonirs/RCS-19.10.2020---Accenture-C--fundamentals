using System;

namespace Day7_while_bool
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool nComparison = n < 5;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine();

            string name = "item";
            while (name != "table")
            {
                Console.Write("Please input an item: ");
                name = Console.ReadLine();
            }
            Console.WriteLine("Finally you inputted TABLE");
            Console.WriteLine();

            bool tired = true;
            while (tired)
            {
                Console.Write("Are you tired now (y/n): ");
                string input = Console.ReadLine();

                if (input == "n")
                {
                    tired = false;
                }
            }
            Console.WriteLine("Finally you are not tired and can continue working!");

            bool hungry = false;
            while (!hungry)
            {
                Console.WriteLine("If you are not hungry, do your homework");
                Console.WriteLine("Are you hungry now (true/false)?");
                string input = Console.ReadLine();
                hungry = bool.Parse(input);
            }
            Console.WriteLine("If your are hungry, please go eat some food");
        }
    }
}
