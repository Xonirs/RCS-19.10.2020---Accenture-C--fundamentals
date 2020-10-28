using System;

namespace Day3_IfUsage3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle driver has exceeded the allowed speed by x km/h (user inputs this). 
            Console.WriteLine("How much did the driver exceed the limit:");
            string speedInput = Console.ReadLine();
            int speed = int.Parse(speedInput);

            //In case the speed exceeds by more than 10, 
            if (speed > 10 && speed <= 20)
            {
                //then the penalty 15 eur, 
                Console.WriteLine("Penalty: 15 EUR");
            }
            //if by more than 20, 
            else if (speed > 20 && speed <= 30)
            {
                //then the penalty is 30,
                Console.WriteLine("Penalty: 30 EUR");
            }
            // and if by more than 30, 
            else if (speed > 30)
            {
                //then the drivers license is lost.
                Console.WriteLine("Driver's license is lost!");
            }
            else
            {
                Console.WriteLine("Keep driving, everything is ok!");
            }
        }
    }
}
