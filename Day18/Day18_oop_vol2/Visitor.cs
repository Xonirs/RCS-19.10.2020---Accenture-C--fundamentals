using System;

namespace Day18_oop_vol2
{
    class Visitor
    {
        public int Age;
        public string FullName;
        public int SeatNumber;
        public double TicketMoney;
        public bool HasMask;

        public void PrintInfo()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Visitor info:");
            Console.ResetColor();
            Console.WriteLine($"FullName: {FullName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"SeatNumber: {SeatNumber}");
            Console.WriteLine($"HasMask: {HasMask}");
            Console.WriteLine();
        }
    }
}