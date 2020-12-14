using System;

namespace Day22_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            Gardener guy = new Gardener("John", 44, 99);
            Park park = new Park("Central park", "best place", guy);
            park.PrintParkInfo();
        }
    }
}
