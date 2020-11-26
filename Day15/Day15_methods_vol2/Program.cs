using System;

namespace Day15_methods_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = GetSumOf5And10();
            Console.WriteLine($"Sum of 5 and 10 is {sum}");
            int sum2 = GetSumOf5And10_vol2();
            Console.WriteLine($"Sum of 5 and 10 is {sum2}");
            Console.WriteLine();

            int a = 5, b = 17;
            Console.WriteLine($"Sum of {a} and {b} is {GetSum(a, b)}");
            int sum3 = GetSum(a, b);
            Console.WriteLine($"Sum of {a} and {b} is {sum3}");
            int sum4 = GetSum(a, 9999);
            Console.WriteLine($"Sum of {a} and 9999 is {sum4}");

            string userName = GetName("Please enter your name");
            string userSurname = GetName("Please enter your surname");
            Console.WriteLine($"Nice to meet your, {userName} {userSurname}!");
        }

        static string GetName(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            return name;
        }

        static int GetSum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        //int - means that the method is going to RETURN a new value of data type int
        //return - the keyword before the value we return
        static int GetSumOf5And10()
        {
            int result = 5 + 10;
            return result;
        }

        static int GetSumOf5And10_vol2()
        {
            return 5 + 10;
        }

    }
}
