using System;

namespace Day6_enum
{
    enum ColorEnum
    {
        Black,
        White,
        Red,
        Cyan,
        Green,
        Blue,
        Yellow
    }

    class Program
    {
        static void Main(string[] args)
        {
            ColorEnum color = ColorEnum.Black;
            Console.WriteLine($"You chose {color} color!");

            Console.WriteLine("Please enter a color number 0-5:");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            ColorEnum userColor = (ColorEnum)number;
            Console.WriteLine($"User chose {userColor} color!");

            Console.WriteLine("Please enter a color:");
            string colorInput = Console.ReadLine();
            ColorEnum userColor2 = (ColorEnum)Enum.Parse(typeof(ColorEnum), colorInput);
            Console.WriteLine($"User chose {userColor2} color!");
        }
    }
}
