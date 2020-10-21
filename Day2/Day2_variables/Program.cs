using System;

namespace Day2_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";

            //defining a variable
            string brothersName; //we can't use a variable who doesn't have a value assigned to

            string emptyText = ""; //empty text
            Console.WriteLine(name);
            //Console.WriteLine(brothersName); //this will not work
            Console.WriteLine(emptyText);

            Console.WriteLine("My brother is born, his name is JOHN");
            //assigning the value to variable brothersName
            brothersName = "JOHN";
            Console.WriteLine("Brother's name:");
            Console.WriteLine(brothersName);

            Console.WriteLine("My brother has changed his name to DAVE");
            //assigning the value to variable brothersName
            brothersName = "DAVE";
            Console.WriteLine("Brother's name:");
            Console.WriteLine(brothersName);

            Console.WriteLine("END");
        }
    }
}
