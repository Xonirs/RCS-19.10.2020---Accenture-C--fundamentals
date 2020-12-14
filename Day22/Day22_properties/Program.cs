using System;

namespace Day22_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            House myHouse = new House("John", "Malkovich");
            myHouse.Name = "old name";
            Console.WriteLine(myHouse.Name);
            myHouse.Name = "new name";
            Console.WriteLine(myHouse.Name);

            myHouse.Floors = 4;
            Console.WriteLine(myHouse.Floors);
            myHouse.Floors = -2;
            Console.WriteLine(myHouse.Floors);

            Console.WriteLine(myHouse.Nickname);
            //myHouse.Nickname = ""; //will not work
            //myHouse.OwnersName = ""; //will not work
            myHouse.ElectricityAmount = 50;
            //Console.WriteLine(myHouse.ElectricityAmount); //will not work
            myHouse.ShowInfo();
        }
    }
}
