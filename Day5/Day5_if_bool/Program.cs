using System;

namespace Day5_if_bool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lastLectureOfTheWeek = false;
            if (lastLectureOfTheWeek)
            {
                //lastLectureOfTheWeek is true
                Console.WriteLine("Great, no more new stuff, my head is exploding!");
            }
            else
            {
                //lastLectureOfTheWeek is false
                Console.WriteLine("WE CAN DO THIS!");
            }

            int number = 10;
            bool numberComparison = number > 5;
            if (numberComparison)
            {
                //do stuff if number greater than 5
            }

            string longSymbols = "asfasdf3453245262452425245@@#%@$%@$";
            if (longSymbols.Length > 25 || numberComparison || lastLectureOfTheWeek)
            {
                //do stuff
            }

            
        }
    }
}
