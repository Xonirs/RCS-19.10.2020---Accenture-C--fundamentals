using System;

namespace Day21_Box
{
    //In Program.Main method create Box object, 
    //fill all the fields and add multiple Items to the Box.
    //Then use method PrintBoxInfo() and print the value 
    //which is returned from method GetBoxVolume().
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box()
            {   
                Id = 123,
                Height = 20,
                Length = 35,
                Weight = 78,
                Width = 37
            };

            box.Items.Add("teddy bear");
            box.Items.Add("pencil");
            box.Items.Add("deck of cards");
            box.Items.Add("ice cream");

            box.PrintBoxInfo();
            int boxVolume = box.GetBoxVolume();
            Console.WriteLine($"Box volums is {boxVolume}");
        }
    }
}
