using System;

namespace Day7_whileAB_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program where the user enters two numbers A and B. 
            //Output all the numbers between A and B
            Console.WriteLine("Please enter a number A:");
            string aInput = Console.ReadLine();
            int a = int.Parse(aInput);
            Console.WriteLine("Please enter a number B:");
            string bInput = Console.ReadLine();
            int b = int.Parse(bInput);

            //Let's try to figure it is A bigger than B or the other way around
            if (b > a)
            {
                a++;
                while (a < b)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
            else if (a > b)
            {
                b++;
                while (b < a)
                {
                    Console.WriteLine(b);
                    b++;
                }
            }
            else
            {
                Console.WriteLine("A and B is equal");
            }

            
        }
    }
}
