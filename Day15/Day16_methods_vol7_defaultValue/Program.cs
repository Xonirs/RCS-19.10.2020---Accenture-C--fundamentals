using System;

namespace Day16_methods_vol7_defaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGreeting("John Apple");
            PrintGreeting();

            PrintGreeting("Howdy mate,", "Ann Perkins");
            PrintGreeting(greetingMessage: "Good morning,");

            PrintMyInfo("Bob");
            PrintMyInfo("Peter", "STRING VALUE");
            PrintMyInfo("Ann", address: "Baker street");
            PrintMyInfo("Josh", "Bowl", "Washington street");

            PrintMyInfo(address: "Baker street", name: "Ann"); //if you want to change order
        }

        //method will execute both with and without a paramter value 'name'
        static void PrintGreeting(string name = "UNKNOWN USER")
        {
            Console.WriteLine($"Hello to {name}");
        }

        //the parameters with default values must be at the end of all parameters
        static void PrintGreeting(string greetingMessage, string name = "UNKNOWN USER")
        {
            Console.WriteLine($"{greetingMessage} {name}");
        }

        //multiple default value parameters
        static void PrintMyInfo(string name, string surname = "SURNAME", string address = "NAMELESS STREET")
        {
            Console.WriteLine($"Name:{name}, Surname:{surname}, Address:{address}");
        }
    }
}
