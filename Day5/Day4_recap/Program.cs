using System;

namespace Day4_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            string mood = "sleepy"; //Console.ReadLine

            if (mood == "sleepy")
            {
                Console.WriteLine("Let's stay at home!");
                //.....
            }
            else if (mood == "energized")
            {
                Console.WriteLine("Let's go to the movies!");
            }
            else
            {
                Console.WriteLine("Let's take a bath");
            }

            int age = 9;
            if (age < 10 && mood == "sleepy") // both conditions must be true in order to execute
            {
                Console.WriteLine("Must go to sleep");
            }

            if (age > 18 || mood == "energized") // one of the conditions must be true in order to execute
            {
                Console.WriteLine("Don't forget to wash dishes");
            }


        }
    }
}
