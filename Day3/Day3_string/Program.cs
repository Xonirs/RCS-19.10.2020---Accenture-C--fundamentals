using System;

namespace Day3_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmsrklhpsfiodsiodgjskldgjskldsdklghsdklghsnopqrstuvwqyz";

            //Substring - to get a part of a string

            //0 - the place to start the part of the text
            //5 - how many letters to take
            //0 - starting position
            //5 - text length
            string first5Letters = alphabet.Substring(0, 5);
            Console.WriteLine($"First 5 letters of the alphabet are {first5Letters}");

            string from3For7letters = alphabet.Substring(2, 7);
            Console.WriteLine($"7 letters from the 3rd position of the alphabet are {from3For7letters}");


            //9 - starting position. the part of the text will be taken from position with index 9
            //if the length is not provided, then from the starting position the rest of the text is taken
            string from10TillEnd = alphabet.Substring(9);
            Console.WriteLine($"From the 10th position rest of the alphabet is {from10TillEnd}");
            Console.WriteLine($"From the 10th position rest of the alphabet is {alphabet.Substring(9)}");


            //Length
            int alphabetLength = alphabet.Length;
            Console.WriteLine($"The length of the alphabet is {alphabetLength}");

            string lastAlphabetLetter = alphabet.Substring(alphabet.Length - 1);
            Console.WriteLine($"The last letter of the alphabet is {lastAlphabetLetter}");
        }
    }
}
