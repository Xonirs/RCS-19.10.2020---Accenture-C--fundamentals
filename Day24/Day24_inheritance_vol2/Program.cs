using System;

namespace Day24_inheritance_vol2
{
    //sealed. sealed class
    //if you don't want other classes to inhert from this class, use sealed
    sealed class SomewhereToSit
    {
        public int SeatCount { get; set; }
    }

    //class Couch : SomewhereToSit //won't work. Error message : "'Couch' cannot derive from sealed type 'SomewhereToSit'"
    class Couch
    {
        public int Width { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SomewhereToSit swts = new SomewhereToSit();
            swts.SeatCount = 5;
        }
    }
}
