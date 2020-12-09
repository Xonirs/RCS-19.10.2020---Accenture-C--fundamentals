using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_vol2
{
    class House
    {
        public string name;
        public string address;

        //static means something which is not associated with an object. it cannot be instantiated.
        //you cannot create an object of a static class
        //you cannot access static class members using an object
        public static int Count = 0;
        public static string City = "Riga";

        public House()
        {
            Count++;
        }

        public House(string _name, string _address)
        {
            name = _name;
            address = _address;
            Count++;
        }

        //everything (variables, etc.) we use inside of a static method must also be static
        public static void PrintSomething()
        {
            //Console.WriteLine($"The house name is {name}"); //this will not work, because 'name' is associated with objects
            Console.WriteLine($"The house count is {Count}"); //this will work, because 'Count' is static
            Console.WriteLine($"The house city is {City}"); //this will work, because 'City' is static
            int weirdSum = Calculator.Sum(Count, City.Length);
            Console.WriteLine($"Here is a weird sum - {weirdSum}, how did i get it?");
        }
    }
}
