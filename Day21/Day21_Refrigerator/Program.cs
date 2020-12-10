using System;

namespace Day21_Refrigerator
{
    /*
     *  In Program.Main method create at least 2 objects 
     *  of class Refrigerator. Use both constructors 
     *  while creating objects. Fill the values for 
     *  fields and use method PrintRefrigeratorInfo().
     */
    class Program
    {
        static void Main(string[] args)
        {
            var ref1 = new Refrigerator()
            {
                Name = "My buddy",
                Height = 190,
                Manufacturer = "Gef",
                Weight = 60,
                Year = 2020
            };
            ref1.PrintRefrigeratorInfo();

            var ref2 = new Refrigerator();
            ref2.Name = "Luxus fridge";
            ref2.Height = 200;
            ref2.Manufacturer = "LEXUS";
            ref2.Weight = 50;
            ref2.Year = 2025;
            ref2.PrintRefrigeratorInfo();

            var ref3 = new Refrigerator("Cool fridge", 195, 60, "Samsung", 2019);
            ref3.PrintRefrigeratorInfo();
        }
    }
}
