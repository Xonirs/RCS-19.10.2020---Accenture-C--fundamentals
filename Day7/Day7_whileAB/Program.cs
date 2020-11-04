using System;

namespace Day7_whileAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program where the user enters two numbers A and B. 
            Console.WriteLine("Please enter a number A:");
            string aInput = Console.ReadLine();
            int a = int.Parse(aInput);
            Console.WriteLine("Please enter a number B:");
            string bInput = Console.ReadLine();
            int b = int.Parse(bInput);
            a++;

            //Output all the numbers between A and B
            while (a < b)
            {                
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
