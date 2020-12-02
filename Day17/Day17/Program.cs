using System;

namespace Day17
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "adaewhrher451345@%!";
            int textCharSize = GetSymbolCount(text);

            int number = 1236466342;
            int digitCount = GetSymbolCount(number);

            PrintSum(10, 15);
            PrintSum(88);
            PrintMultiplication(13, 67);
            PrintMultiplication(13);
            PrintMultiplication();
            PrintMultiplication(b: 56);

            int[] myFavNumbers = CreateANewArray(10, 7, 13);
            Console.WriteLine("My favorite number in an array are:");
            foreach (int favNumber in myFavNumbers)
            {
                Console.Write(favNumber + " ");
            }
        }

        static int[] CreateANewArray(int number1, int number2, int number3)
        {
            int[] resultArray = { number1, number2, number3 };

            //string[] alternativeArray = new string[3];
            //for (int i = 0; i < alternativeArray.Length; i++)
            //{
            //    alternativeArray[i] = Console.ReadLine();
            //}

            return resultArray;
        }

        static void PrintSum(int a, int b = 7777)
        {
            Console.WriteLine($"The sum of a:{a} and b:{b} is {a + b}");
        }

        static void PrintMultiplication(int a = 888, int b = 7777)
        {
            Console.WriteLine($"The multiplication of a:{a} and b:{b} is {a * b}");
        }


        static int GetSymbolCount(int number)
        {
            var resultCount = number.ToString().Length;
            return resultCount;
        }

        static int GetSymbolCount(string someText)
        {
            var resultCount = someText.Length;
            return resultCount;
        }
    }
}

