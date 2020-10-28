using System;

namespace Day3_recap_if
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true) //doesn't make any sense, but works with no errors
            {
                Console.WriteLine("THIS WILL ALWAYS EXECUTE");
            }

            string textExample = "!@#$@%#FSDFSDF";
            Console.WriteLine(textExample);

            int a = 50, b = 20;
            if (a > b)
            {
                Console.WriteLine("a is greater than b!"); //this will execute, because condition a > b is true
            }

            if (a < b)
            {
                Console.WriteLine("b is greater than a!"); //this will not execute, because condition a < b is false
            }
            Console.WriteLine();

            int age = 20;

            if (age > 30)
            {
                Console.WriteLine("Person has age above 30");
            }
            else
            {
                Console.WriteLine("Person is under age 30");
            }

            if (age > 50) 
            {
                Console.WriteLine("Person has age above 50");
            }
            else if (age > 30)
            {
                Console.WriteLine("Person has age above 30");
            }
            else
            {
                Console.WriteLine("Person age is below 30");
            }
            Console.WriteLine();


            string name = "Betty";
            if (name == "Ann")
            {
                Console.WriteLine("Hi Ann! Ann is my sister.");
            }
            else if (name == "Bob")
            {
                Console.WriteLine("Hi Bob! Bob is my brother.");
            }
            else
            {
                Console.WriteLine($"Hi {name}! Nice to meet you.");
            }

            if (age == 21)
            {
                //message
            }

            double salary = 950.42;
            if (salary > 1000)
            {
                Console.WriteLine("Congratulations, you have a really large salary!");
            }
            else if (salary == 666.66)
            {
                Console.WriteLine("Well this is just funny, mr. devil!");
            }
            else if (salary != 0)
            {
                Console.WriteLine("Well, good to have any salary!");
            }



            Console.WriteLine("END OF CODE");
        }
    }
}



