using System;

namespace Day21_Car
{
    class Program
    {        
        //In Program.Main method create a Car object. 
        //Call method PressHorn() couple of times and 
        //then print the message which is returned from 
        //method GetHornCount().
        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.PressHorn();
            audi.PressHorn();
            audi.PressHorn();
            audi.PressHorn();
            audi.PressHorn();
            audi.GetHornCount();

            string message = audi.GetHornCount();
            Console.WriteLine(message);

            Console.WriteLine(audi.GetHornCount());
        }
    }
}
