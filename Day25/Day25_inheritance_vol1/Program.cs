using System;

namespace Day25_inheritance_vol1
{
    //to inherit - it means for a class to obtain all the public members (properties, methods, etc.)
    //Derived class (child) - the class that inherits from another class
    //Base class (parent) - the class being inherited from
    //IMPORTANT - in C# you can inherit only from a single class

    class LivingCreature
    {
        public bool CanLiveUnderWater { get; set; }
        public bool CanFly { get; set; }
        public bool Mammal { get; set; }
    }

    class Human : LivingCreature
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public void SayHi(string name)
        {
            Console.WriteLine($"Hi, {name}, my names is {Name} {Surname}");
        }
    }

    class Adult : Human
    {
        public int Salary { get; set; }
        public void PrintSalary()
        {
            Console.WriteLine($"My monthly salary is {Salary}");
        }
    }

    class Child : Human
    {
        public int BabyTeeth { get; set; }
        public void PrintBabyTeethCount()
        {
            Console.WriteLine($"I have {BabyTeeth} baby teeth!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human() { Name = "John", Surname = "Bertum" };
            human1.SayHi("George");
            human1.Mammal = true;
            
            Adult adult1 = new Adult();
            adult1.Name = "Ann";
            adult1.Surname = "Possum";
            adult1.SayHi("David");
            adult1.Salary = 900;
            adult1.PrintSalary();
            adult1.Mammal = true;

            Child child1 = new Child();
            child1.Name = "Billy";
            child1.Surname = "Retgus";
            child1.SayHi("Harry");
            child1.BabyTeeth = 10;
            child1.PrintBabyTeethCount();
            child1.CanFly = false;
        }
    }
}
