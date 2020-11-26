using System;

namespace Day15_methods_vol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print1to10();
            Print1to10();
            Console.Write("Name a number to print from 1..N : ");
            int userNumber = int.Parse(Console.ReadLine());
            Print1toN(userNumber);
            int x = 17;
            Print1toN(x);
            Print1toN(14);
            //Print1toN(); //this will not work, method needs the parameter

            PrintAtoB(19, 27);
            int n = -7;
            PrintAtoB(n, userNumber);
        }

        //void - means that method does not create a new value at the end
        //() - means that method doesn't need any value from "caller"
        //Print1to10 - method name
        static void Print1to10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //(int number):
        //defining a parameter "number"
        //method is saying - "i need an INT value to do my work. inside the method i will call this value - 'number'."
        //method will not work without this parameter value
        static void Print1toN(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintAtoB(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
