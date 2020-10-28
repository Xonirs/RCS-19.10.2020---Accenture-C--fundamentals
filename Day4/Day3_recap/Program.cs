using System;

namespace Day3_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("              saddfsfsfsafsad             sdfsfsafasd            fdfdfd!!!@@$%^&*()");
            Console.WriteLine();
            Console.WriteLine("Let's recap everything");

            Console.WriteLine("12345 abcde 'asdas'  !@#$% zyubjh 456987");

            Console.WriteLine("My name is \"John\"."); //Prints: My name is "John".
            Console.WriteLine(@"My age is ""20""."); //Prints: My age is "20".

            string textWithQuotes = @"The name of my city is ""Riga"" which is in Latvia.";
            Console.WriteLine(textWithQuotes);


            string name = "Bob";
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"{name} is 19 years old.");
            Console.WriteLine($"{name} has 2 sisters, but {name} has no pets.");

            int age = 99;
            bool wasPreviousHWHard = true;

            Console.WriteLine(age);
            Console.WriteLine(wasPreviousHWHard);

            Console.WriteLine($"My age is {age}, was yesterday's homework hard: {wasPreviousHWHard}.");

            Console.WriteLine("Please enter your favorite color:");
            string color = Console.ReadLine();
            Console.WriteLine($"You typed {color}. Length of your color is {color.Length}.");
            Console.WriteLine();

            //Console.Write - writes the value and DOESN'T  move to next line as WriteLine
            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"Your name is {name}, surname is {surname}.");

            //Substring
            string sentence = "Very soon America will have election.";
            string subString1 = sentence.Substring(10, 5);
            string subString2 = sentence.Substring(17);
            Console.WriteLine(subString1);
            Console.WriteLine(subString2);

            //text -> number
            Console.Write("Please enter your birthyear: ");
            string yearInput = Console.ReadLine();
            //Convert.ToInt32 OR int.Parse
            int year1 = Convert.ToInt32(yearInput);
            int year2 = int.Parse(yearInput);
            Console.WriteLine($"Your birthyear is {year1}, that means you are {2020 - year2} years old.");

            //any data type -> text
            // .ToString()
            int salary = 500;
            bool isItDark = true;
            double temp = 35.3;

            string salaryConverted = salary.ToString(); 
            Console.WriteLine($"Value: {salaryConverted}, length: {salaryConverted.Length}");

            string isItDarkConverted = isItDark.ToString();
            Console.WriteLine($"Value: {isItDarkConverted}, length: {isItDarkConverted.Length}");

            string tempConverted = temp.ToString();
            Console.WriteLine($"Value: {tempConverted}, length: {tempConverted.Length}");

            Console.WriteLine();

            int x = 10, b = 5, a = 12;
            int z = x * b + a - 137;

            string abc = "Text1.";
            string xyz = "teXT2.";
            string jkl = abc + " " + xyz + abc + ";";
        }
    }
}

