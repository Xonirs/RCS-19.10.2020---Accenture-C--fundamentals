using System;

namespace Day6_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create console application, which will ask for 2 numbers and for some kind of mathematical action (+,-,*,/). 
            //Print the result of this action in Console. For example, 5+3=8. Use switch.
            Console.WriteLine("Input number1:");
            string numberInput1 = Console.ReadLine();
            int number1 = int.Parse(numberInput1);

            Console.WriteLine("Input number2:");
            string numberInput2 = Console.ReadLine();
            int number2 = int.Parse(numberInput2);

            Console.WriteLine("Input an action (+ - * /):");
            string action = Console.ReadLine();
            switch (action)
            {
                case "+":
                    int sum = number1 + number2;
                    Console.WriteLine($"{number1} + {number2} = {sum}");
                    break;
                case "-":
                    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                    break;
                case "/":
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                    break;
                default:
                    Console.WriteLine("Invalid action!");
                    break;
            }

        }
    }
}
