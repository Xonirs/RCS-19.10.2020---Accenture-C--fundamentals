using System;

namespace Day3_recap_AND_OR_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            string color = "red";

            if (number > 100 || color == "green")
            {
                Console.WriteLine("A");
            }

            if (number >= 100 || color == "green")
            {
                Console.WriteLine("B");
            }

            if (number >= 100 && color == "green")
            {
                Console.WriteLine("C");
            }

            //50 <= x < 100 
            int x = 65;
            if (50 <= x && x < 100)
            {

            }

        }
    }
}

/*
 * 3.2
 *  operator for string ||
 *  
 * "So we had to place values that are bigger 50 and less then one hundred
And we had to write as it is smaller then 50 to get the program read it 
as it is bigger then 50... "

 * 
 * 
 * 
 * */
