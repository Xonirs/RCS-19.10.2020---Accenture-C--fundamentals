using System;

namespace Day18_oop_vol1
{
    class Program
    {
        static void Main(string[] args)
        {
            //null - a non existing value
            //if we don't create A NEW instance of a class
            //the default value is null (for classes)
            Rectangle nullRectangle = null;
            if (nullRectangle == null)
            {
                Console.WriteLine("This object doesnt exist");
            }

            Rectangle rectangle = new Rectangle("Garden");
            rectangle.height = 100;
            rectangle.width = 50;
            Console.WriteLine($"Width:{rectangle.width}, Height:{rectangle.height}");
            Console.WriteLine();

            Rectangle rectangle2 = new Rectangle("Basketball court");
            rectangle2.height = 37;
            rectangle2.width = 17;

            rectangle.PrintInfo();
            rectangle2.PrintInfo();

            Rectangle rectangle3 = new Rectangle("NY Square", 77, 88);
            rectangle3.PrintInfo();

            //rectangle3.name = //this will not work, due to the private

            Rectangle rectangle4 = new Rectangle("Central park", 55, 55);
            rectangle4.PrintInfo();
        }
    }
}
