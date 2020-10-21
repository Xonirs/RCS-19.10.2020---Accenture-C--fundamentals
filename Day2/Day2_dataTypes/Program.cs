using System;

namespace Day2_dataTypes
{
    class Program
    {
        //This is the entry point for Console application
        static void Main(string[] args)
        {
            //this is a test comment and will not be executed. i can write what i want

            //int = integer, numbers
            int myNumber = 100;

            //string = text
            string myText = "Hi! My name is John.";

            Console.WriteLine("We can't see stars tonight.");
            Console.WriteLine(myText);

            int number = 20;
            string text = "Mary";
            double salary = 500.51;
            char symbol = '@';
            char symbolNumber = '5';
            char symbolText = 'p';
            float temperature = 12.4F;
            bool isItDark = true;
            bool isItRaining = false;
            bool didWeHaveAFirstBreak = true;

            Console.WriteLine("Here are all the values:");
            Console.WriteLine(); //an empty Console.WriteLine statement prints an empty line
            Console.WriteLine("Printing with variable names:");
            Console.WriteLine(number);
            Console.WriteLine(text);
            Console.WriteLine(salary);
            Console.WriteLine(symbol);
            Console.WriteLine(symbolNumber);
            Console.WriteLine(symbolText);
            Console.WriteLine(temperature);
            Console.WriteLine(isItDark);
            Console.WriteLine(isItRaining);
            Console.WriteLine(didWeHaveAFirstBreak);

            Console.WriteLine(); //an empty Console.WriteLine statement prints an empty line
            Console.WriteLine("Printing without variable names:");
            Console.WriteLine(20);
            Console.WriteLine("Mary");
            Console.WriteLine(500.51);
            Console.WriteLine('@');
            Console.WriteLine('5');
            Console.WriteLine('p');
            Console.WriteLine(12.4F);
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(true);

        }
    }
}
