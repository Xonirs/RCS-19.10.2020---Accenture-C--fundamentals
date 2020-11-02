using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_switch
{
    class TestSwitch
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            if (name == "Bob")
            {
                Console.WriteLine("Bob, is my brother");
            }
            else if (name == "Ann")
            {
                Console.WriteLine("Ann is my teacher");
            }
            else if (name == "Mary")
            {
                Console.WriteLine("Mary is my best friend!");
            }
            else
            {
                Console.WriteLine("Sorry, we don't recognize you!");
            }
        }
    }
}
