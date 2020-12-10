using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_Box
{
    //Create a class Box. Add public fields – 
    //Id, Height, Width, Length, Weight, Items.
    //Choose appropriate data types for all of them.
    //Field Items is a list of strings of the items inside the box.
    //Create a public method – void PrintBoxInfo(), 
    //which will print information about all of the fields and 
    //will list all of the items.Create a public method – 
    //int GetBoxVolume(), which will calculate volume for the box
    //(volume is calculated by multiplying all of the measurements). 
    class Box
    {
        public int Id;
        public int Height;
        public int Width;
        public int Length;
        public int Weight;
        public List<string> Items = new List<string>();

        public int GetBoxVolume()
        {
            return Height * Width * Length;
        }

        public void PrintBoxInfo()
        {
            Console.WriteLine("Here is the box info:");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Weight: {Weight}");
            if (Items.Count > 0)
            {
                Console.WriteLine($"Here are the {Items.Count} items:");
                foreach (var item in Items)
                {
                    Console.WriteLine(item);
                }
            }            
            Console.WriteLine();
        }
    }
}
