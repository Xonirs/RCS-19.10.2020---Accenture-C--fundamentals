using System;

namespace Day7_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine($"END OF FIRST LOOP, N={n}");

            int x = 10;
            int y = -3;
            int counter = 1;
            while (x > 5 || y < 5)
            {
                Console.WriteLine($"x:{x}, y:{y}, count:{counter}");
                x--; //reduces by one
                y++; //increases by one
                counter++;
            }
            Console.WriteLine($"END OF SECOND LOOP, N={n}");

            int number = 0;
            while (number < 3)
            {
                int extraNumber = 10;
                Console.WriteLine($"number:{number}, extraNumber:{extraNumber}");
                number++;
                extraNumber--;
            }
            Console.WriteLine();

            int number2 = 0;
            int extraNumber2 = 10;
            while (number2 < 3)
            {                
                Console.WriteLine($"number:{number2}, extraNumber:{extraNumber2}");
                number2++;
                extraNumber2--;
            }
            Console.WriteLine();

            //VERSION NO.1, INCORRECT
            //string text1 = "abcd";
            //if (!string.IsNullOrEmpty(text1)) //checking if text not empty
            //{
            //    string message = "Your text: " + text1;
            //}
            //Console.WriteLine(message); //this causes an error

            //VERSION NO.2, CORRECT
            string text1 = "abcd";
            string message = "";
            if (!string.IsNullOrEmpty(text1)) //checking if text not empty
            {
                message = "Your text: " + text1;
            }
            Console.WriteLine(message); //this DOESN'T cause an error
        }
    }
}
