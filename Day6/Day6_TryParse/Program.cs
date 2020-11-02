using System;

namespace Day6_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age: ");
            string ageInput = Console.ReadLine();

            //int age = int.Parse(ageInput); //old way, assuming values always in correct data types

            //age - the int variable, which will have the converted number, IF the parse is possible
            //ageInput - the string variable, which is user's input
            //didParseSucceed - bool variable, whether it is possible to do a parse
            //didParseSuccedd - true (if parse possible) or false (if parse not possible)
            int age;
            bool didParseSucceed = int.TryParse(ageInput, out age);
            if (didParseSucceed) //checking if it is possible to do a parse
            {
                Console.WriteLine($"Your age is {age}");
            }
            else
            {
                Console.WriteLine($"This value '{ageInput}' cannot be converted to a number");
            }
            

            Console.Write("What is your salary: ");
            string salaryInput = Console.ReadLine();
            double salary;
            bool didParseSucceed2 = double.TryParse(salaryInput, out salary);
            if (didParseSucceed2) //checking if it is possible to do a parse
            {
                Console.WriteLine($"Your age is {salary}");
            }
            else
            {
                Console.WriteLine($"This value '{salaryInput}' cannot be converted to a number with decimal point");
            }

            Console.Write("Did you vote: ");
            string voteInput = Console.ReadLine();
            bool didVote;
            bool didParseSucceed3 = bool.TryParse(voteInput, out didVote);
            if (didParseSucceed3) //checking if it is possible to do a parse
            {
                Console.WriteLine($"Did user vote: {didVote}");
            }
            else
            {
                Console.WriteLine($"This value '{voteInput}' cannot be converted to a bool value");
            }
        }
    }
}
