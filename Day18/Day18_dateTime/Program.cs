using System;

namespace Day18_dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //year - 2020, month - 12, day - 3
            DateTime dateTimeTest = new DateTime(2020, 12, 3); 

            DateTime dt = new DateTime(2020, 12, 3, 21, 29, 8);
            Console.WriteLine(dt); //the same as Console.WriteLine(dt.ToString());

            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(dt.ToShortTimeString());

            //see classroom link
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
            Console.WriteLine(dt.ToString("dd $ MM $ yyyy"));
        }
    }
}
