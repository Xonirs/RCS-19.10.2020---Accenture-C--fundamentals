using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_Park
{
    //properties – Name, Address, MainGardener
    class Park
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Gardener MainGardener { get; set; }

        public Park(string n, string a, Gardener g)
        {
            Name = n;
            Address = a;
            MainGardener = g;
        }

        public void PrintParkInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Address:{Address}");
            Console.WriteLine($"MainGardener.Name:{MainGardener.Name}");
            Console.WriteLine($"MainGardener.Age:{MainGardener.Age}");
            Console.WriteLine($"MainGardener.Experience:{MainGardener.Experience}");
        }
    }
}
