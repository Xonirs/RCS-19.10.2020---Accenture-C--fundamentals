using System;

namespace Day6_switch_enum
{
    enum WeekDayEnum
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeekDayEnum day = WeekDayEnum.Sunday;
            switch (day)
            {
                case WeekDayEnum.Monday:
                    Console.WriteLine("I don't want to work today!");
                    break;
                case WeekDayEnum.Tuesday:
                case WeekDayEnum.Wednesday:
                case WeekDayEnum.Thursday:
                    Console.WriteLine("Middle of the week, let's earn our weekend!");
                    break;
                case WeekDayEnum.Friday:
                    Console.WriteLine("Friday finally is here");
                    break;
                case WeekDayEnum.Saturday:
                case WeekDayEnum.Sunday:
                    //code for both - Saturday and Sunday
                    Console.WriteLine("Time to rest!");
                    break;
                default:
                    break;
            }
        }
    }
}
