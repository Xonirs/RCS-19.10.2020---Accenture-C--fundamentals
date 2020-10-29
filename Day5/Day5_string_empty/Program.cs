using System;

namespace Day5_string_empty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to input their name
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            
            //Checkin if the name is empty
            if (string.IsNullOrEmpty(name))
            {
                //If it was empty, asking to input again
                Console.Write("You can't input empty values, please enter again:");
                name = Console.ReadLine();
            }            

            if (!string.IsNullOrEmpty(name)) //means : if string is NOT empty
            {
                Console.Write($"Hello, {name}!");
            }

            string aa = string.Empty; // "", just an empty string
        }
    }
}
