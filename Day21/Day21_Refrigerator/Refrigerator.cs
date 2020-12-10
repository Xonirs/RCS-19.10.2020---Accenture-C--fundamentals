using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_Refrigerator
{
    /*
     * Create a class Refrigerator. Add public fields – Name, Height, Weight, 
     * Manufacturer, Year. Choose appropriate data types for all of them. 
     * Create 2 constructors for this class – one without parameters and 
     * one with some (or all) of them. Create a public method – 
     * void PrintRefrigeratorInfo(), which will print all the information 
     * known about the fridge.
     */
    class Refrigerator
    {
        public string Name;
        public int Height;
        public double Weight;
        public string Manufacturer;
        public int Year;

        public Refrigerator()
        {

        }

        public Refrigerator(string _name, int _height, double _weight, 
            string _manufacturer, int _year)
        {
            Name = _name;
            Height = _height;
            Weight = _weight;
            Manufacturer = _manufacturer;
            Year = _year;
        }

        public void PrintRefrigeratorInfo()
        {
            Console.WriteLine("Here is the refrigerator info");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Name:{Height}");
            Console.WriteLine($"Name:{Weight}");
            Console.WriteLine($"Name:{Manufacturer}");
            Console.WriteLine($"Name:{Year}");
            Console.WriteLine();
        }
    }
}
