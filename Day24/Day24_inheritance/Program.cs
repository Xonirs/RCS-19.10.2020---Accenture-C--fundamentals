using System;

namespace Day24_inheritance
{
    //Inheritance
    //it is possible to inherit fields/properties/methods/etc. from one class to another
    //Derived class (child) - this is the class that inherits
    //Base class (parent) - this is the class that is being inherited from

    class Computer //Base class (parent)
    {
        private string TestField;
        public int Memory { get; set; }
        public int DiskSpace { get; set; }
    }

    //using C#, class can inherit from only just ONE class at a time
    //but you can inherit from multiple interfaces
    class Laptop : Computer //Laptop - derived class (child)
    {
        public bool HasTouchScreen { get; set; }
    }

    class Server : Computer //Derived class (child)
    {
        public int DailyUpTime { get; set; }
    }

    class Tablet : Laptop //Tablet - derived class (child)
    {
        public string MobileOS { get; set; }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Computer computer = new Computer() 
            {
                DiskSpace = 256,
                Memory = 32
            };

            Laptop laptop = new Laptop();
            laptop.HasTouchScreen = false;
            laptop.Memory = 16;
            laptop.DiskSpace = 128;

            Server server = new Server();
            server.DailyUpTime = 23;
            server.DiskSpace = 1024;
            server.Memory = 64;

            Tablet tablet = new Tablet();
            tablet.MobileOS = "iOS";
            tablet.HasTouchScreen = true;
            tablet.Memory = 8;
            tablet.DiskSpace = 512;

        }
    }
}
