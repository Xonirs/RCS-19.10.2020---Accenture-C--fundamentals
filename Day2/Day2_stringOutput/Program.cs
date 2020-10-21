using System;

namespace Day2_stringOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string message = "My name is: ";
            //3 options to handle strings
            //nr.1: plus sign '+'            
            Console.WriteLine("NR.1");
            string combined1 = message + name;
            Console.WriteLine(combined1);
            Console.WriteLine(message + name); //the same result as line above

            //nr.2: dollar sign '$' and curly bracket with variable name {name}
            Console.WriteLine("NR.2");
            string combined2 = $"{5 * 10}";
            string combined2test = $"5 * 10";
            Console.WriteLine(combined2);
            Console.WriteLine(combined2test);
            string combined3 = $"{message}{name}"; //recommended way
            string combined4 = $"{message + name}";
            Console.WriteLine(combined3);
            Console.WriteLine(combined4);
            Console.WriteLine($"{message}{name}");

            //nr.3: string.Format
            Console.WriteLine("NR.3");
            string combined5 = string.Format("{0}{1}", message, name);
            Console.WriteLine(combined5);
            Console.WriteLine(string.Format("{0}{1}", message, name));
            string a = "house";
            string b = "river";
            string c = "door";
            Console.WriteLine(string.Format("My favorite thing is {2}, my {0} color is blue and i live by {1}", a, b, c));
        }
    }
}
