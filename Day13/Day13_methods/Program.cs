using System;

namespace Day13_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstMethod();
            FirstMethod();
            FirstMethod();

            //GreetingMethod(); //will not work, because method is defined with a single parameter
            //GreetingMethod(false); //will not work, because method expects string as a parameter
            GreetingMethod("Bob");
            GreetingMethod("Tom");
            string userSurname = "Jumbo";
            GreetingMethod(userSurname);
        }

        //void - means that the method DOESN'T return (create) any value
        //() - means that there is no parameter for this method use
        //parameter - a value we can give to the method for usage
        public static void FirstMethod()
        {
            Console.WriteLine("Hello World from a method! + this new text");
        }

        public static void GreetingMethod(string name)
        {
            Console.WriteLine($"Greetings, Mr. {name}!");
        }
    }
}
