using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_oop_vol1
{
    class Rectangle
    {
        #region Fields
        //default access modifier for class member is private
        //private - the code can be accessed only within the same class
        //public - the code can be accessed anywhere
        public int width, height;
        private string name;
        #endregion

        #region Constructors
        public Rectangle(string _name)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rectangle with name has been created!");
            Console.ResetColor();
            name = _name;
        }

        public Rectangle(string _name, int _width, int _height)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rectangle with name and dimensions has been created!");
            Console.ResetColor();
            name = _name;
            width = _width;
            height = _height;
        }
        #endregion

        #region Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Rectangle '{name}' info:");
            Console.WriteLine($"The rectangle height - {height}");
            Console.WriteLine($"The rectangle width - {width}");
            Console.WriteLine($"The rectangle perimiter - {Perimeter()}");
            Console.WriteLine($"The rectangle area - {Area()}");
            if (IsSquare())
            {
                Console.WriteLine("The rectangle is a square");
            }
            else
            {
                Console.WriteLine("The rectangle is not square");
            }
            Console.WriteLine();
        }

        public int Perimeter()
        {
            return 2 * (height + width);
        }

        public int Area()
        {
            return height * width;
        }

        public bool IsSquare()
        {
            //if (width == height)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //return width == height ? true : false;

            return width == height;
        }
        #endregion
    }
}
