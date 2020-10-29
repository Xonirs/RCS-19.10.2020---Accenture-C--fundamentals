using System;

namespace Day5_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 24343430;

            switch (number) //so inside we always put a variable
            {
                case 10: //we have to write a value according to the data type for variable 'number'
                    //after "case 10:" we can put C# code
                    Console.WriteLine("The value was 10");
                    break; //break ends the case code block
                case 20:
                    Console.WriteLine("The value was 20");
                    break;
                default:
                    Console.WriteLine($"Default case, number: {number}");
                    break;
            }

            int age = 18;

            switch (age)
            {
                case 18:
                    Console.WriteLine("You can now purchase alcohol!");
                    break;
                case 40:
                    Console.WriteLine("From this year you can become a president");
                    break;
                case 13:
                    Console.WriteLine("You are now being called a 'teen'");
                    break;
                case 60:
                    Console.WriteLine("You are allowed to become a pope!");
                    break;
                default:
                    Console.WriteLine("Nothing new this year!");
                    break;
            }
        }
    }
}
