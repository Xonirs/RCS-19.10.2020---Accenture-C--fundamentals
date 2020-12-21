using System;

namespace Day25_virtual_base
{
    class Vehicle
    {
        public virtual void DrivingSounds()
        {
            Console.WriteLine("Generic driving sounds");
        }
    }

    class Car : Vehicle
    {
        public override void DrivingSounds()
        {
            Console.WriteLine("Car sounds: BRUM BRUM");
            //there is a possibility to call the base class implementation
            base.DrivingSounds();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();
            vehicle.DrivingSounds();
        }
    }
}
