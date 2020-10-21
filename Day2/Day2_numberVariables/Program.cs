using System;

namespace Day2_numberVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int otherNumber;
            //Console.WriteLine(otherNumber); //we can't use unassigned variable
            Console.WriteLine("otherNumber");
            otherNumber = 45;
            Console.WriteLine(otherNumber);
            otherNumber = 500 - 317;
            Console.WriteLine(otherNumber);

            otherNumber = 12345 + number + 3;
            Console.WriteLine(otherNumber);
                        
            Console.WriteLine("number");
            number = otherNumber - 5;
            Console.WriteLine(number);

            number = number - 5;
            Console.WriteLine(number);
            
            Console.WriteLine("END");
        }
    }
}
