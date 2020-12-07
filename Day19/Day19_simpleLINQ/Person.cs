using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_simpleLINQ
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public ConsoleColor EyeColor;
        public bool HasSeenHarryPotter;

        public Person(string _name, string _surname, 
            int _age, 
            ConsoleColor _eyeColor, bool hasSeenHP)
        {
            Name = _name;
            Surname = _surname;
            Age = _age;
            EyeColor = _eyeColor;
            HasSeenHarryPotter = hasSeenHP;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Person's info:");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Surname:{Surname}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"EyeColor:{EyeColor}");
            Console.WriteLine($"HasSeenHarryPotter:{HasSeenHarryPotter}");
            Console.WriteLine();
        }
    }    
}
