using System;

namespace Day2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name!");
            //ReadLine - gets the text from the user until user presses ENTER
            //NOTE: from Console.ReadLine we can ONLY GET TEXT VALUES
            string name = Console.ReadLine(); 
            Console.WriteLine("Your name is:");
            Console.WriteLine(name);
        }
    }
}
