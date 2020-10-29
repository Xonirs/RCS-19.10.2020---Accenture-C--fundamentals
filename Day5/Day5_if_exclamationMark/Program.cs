using System;

namespace Day5_if_exclamationMark
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sunny = false;

            //! - exclamation mark
            //exclamation gives the opposite value of bool. so true becomes false and false becomes true
            //for reading the code: ! means NOT

            if (!sunny) //read it like: if NOT sunny
            {
                Console.WriteLine("It is NOT sunny");
            }

            string day = "thursday";

            if (sunny && day != "monday")
            {
                Console.WriteLine("A");
            }

            if (!sunny && day != "monday")
            {
                Console.WriteLine("B");
            }
        }
    }
}
