using System;

namespace Day5_if_condition_grouping
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            string relative = "sister";
            string weather = "cloudy";

            if ((age > 10 && weather == "sunny") || relative == "father")
            {
                Console.WriteLine("I can go play outside");
            }

            if (age > 18 && (weather == "sunny" || relative == "father"))
            {
                Console.WriteLine("I can go play in the lake");
            }
        }
    }
}
