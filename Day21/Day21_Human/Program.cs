using System;

namespace Day21_Human
{
    class Program
    {
        //Create a class Human. Add public fields – 
        //Name, Height, Gender, RelativeCount, HasChildren. 
        //Choose appropriate data types for all of them. In Program.Main method, 
        //create multiple Human objects and fill all the fields with values.
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.Name = "John";
            human1.Height = 164;
            human1.Gender = "a man";
            human1.RelativeCount = 5;
            human1.HasChildren = false;

            Human human2 = new Human();
            human2.Name = "Marry";
            human2.Height = 157;
            human2.Gender = "a woman";
            human2.RelativeCount = 12;
            human2.HasChildren = true;
        }
    }
}
