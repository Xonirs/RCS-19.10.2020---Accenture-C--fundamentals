using System;

namespace Day8_digitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program which calculates the sum of digits of the entered number 
            //(e.g. 245 sum of digits is 2 + 4 + 5 = 11).

            //Ask for a number + ReadLine
            Console.WriteLine("Please input a number:");
            string numberInput = Console.ReadLine();
            //int sum definition
            int sum = 0;

            //Determine the length of the input : string.Length
            int inputLength = numberInput.Length;

            //LOOP BEGINS. LOOP CONDITION: HOW MANY TIMES THE LOOP WILL EXECUTE?
            //keep going while there are still numbers -> as long as the length
            int counter = 0;
            while (counter < inputLength)
            {
                //Break up the input into individual digits, "123" -> "1" : Substring
                string symbol = numberInput.Substring(counter, 1);
                //"1" -> 1 : Parse
                int newDigit = int.Parse(symbol);
                //Keep adding digits until all have been added, add new number to sum
                sum = sum + newDigit;
                
                Console.WriteLine($"Loop iteration: {counter}. Symbol: {symbol}. Sum:{sum}.");
                counter++;
            }
            //LOOP ENDS

            //prints sum of digits
            Console.WriteLine($"Sum of {numberInput} digits is {sum}.");
        }
    }
}
