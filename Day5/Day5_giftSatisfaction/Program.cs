using System;

namespace Day5_giftSatisfaction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application which will take from user a gift item, it’s price and color. 
            //The gift is accepted if the item is “computer”. “phone”, “piano” or the item’s value is above 1000. 
            //Also the phone is accepted only if it’s in green color. Print only a single message if the gift is accepted or it is not.

            Console.Write("What is the gift item: ");
            string gift = Console.ReadLine();

            Console.Write("What is the gift color: ");
            string color = Console.ReadLine();

            Console.Write("What is the gift price: ");
            string priceInput = Console.ReadLine();
            int price = int.Parse(priceInput);

            if (gift == "computer" || (gift == "phone" && color == "green") || gift == "piano" || price > 1000)
            {
                Console.WriteLine($"Gift {gift} is accepted!");
            }
            else
            {
                Console.WriteLine("Gift will not be accepted!");
            }

        }
    }
}
