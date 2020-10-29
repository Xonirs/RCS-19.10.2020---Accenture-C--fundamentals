using System;

namespace Day5_enum
{
    enum SeasonEnum
    {
        Autumn,
        Winter,
        Spring,
        Summer
    }

    class Program
    {
        static void Main(string[] args)
        {
            SeasonEnum season = SeasonEnum.Autumn;
            Console.WriteLine($"Now the season is {season}");

            if (season == SeasonEnum.Winter)
            {
                Console.WriteLine("it must be cold");
            }
            else
            {
                Console.WriteLine("I guess, it's not that cold");
            }

            //from int to enum
            int userInput = 2;
            SeasonEnum seasonTest1 = (SeasonEnum)userInput;
            Console.WriteLine($"Test1 season is {seasonTest1}");

            //from enum to int
            SeasonEnum seasonTest2 = SeasonEnum.Winter;
            int userTest2 = (int)seasonTest2;
            Console.WriteLine($"The numeration for {seasonTest2} is {userTest2}");
        }
    }

    //example
    enum UserStatus
    {
        Active,
        Deleted,
        NeedsVerification,
        Blocked,
        NONactive
    }
}
