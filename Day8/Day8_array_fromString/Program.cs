using System;

namespace Day8_array_fromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Christopher";
            char firstLetter = name[0];
            char lastLetter = name[name.Length - 1];
            Console.WriteLine($"String {name} first letter is {firstLetter}, " +
                $"last letter is {lastLetter} and the lenght is {name.Length}");

            //THIS WILL NOT WORK
            //name[4] = 'A'; //will give error

            //to convert from any data type or any value to string, use .ToString()
            string firstLetterStringEdition = firstLetter.ToString();
        }
    }
}
