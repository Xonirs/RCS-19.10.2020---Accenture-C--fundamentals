using System;

namespace Day25_abstraction
{
    //abstract class - restricted class that cannot be used to create objects. to use it, you must inherit from it.
    abstract class Animal
    {
        public string Name { get; set; }
        //abstract method - can only be used inside the abstract class. 
        //                  it does not have a body (no implementation), just a method signature
        //                  The method body MUST be provide by the derived class
        public abstract void AnimalSound();

        public void Sleep() { Console.WriteLine("zzz...zzz"); }

        public void ExecuteAnimalDay()
        {
            Sleep();
            Console.WriteLine($"Animal {Name} is waking up");
            for (int i = 0; i < 3; i++) { AnimalSound(); }
            Sleep();
        }
    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("woof woof woof!");
        }

        public void SniffPeople() { Console.WriteLine("Sniffing people right now!"); }
    }

    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("meow meow meow!");
        }

        public void ScratchPeople() { Console.WriteLine("Scratching people right now!"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal(); //cannot be done
            Dog dog = new Dog();
            dog.Name = "Fluffy";
            dog.ExecuteAnimalDay();
            dog.SniffPeople();
            Console.WriteLine();

            Cat cat = new Cat();
            cat.Name = "Buffy";
            cat.ExecuteAnimalDay();
            cat.ScratchPeople();
            Console.WriteLine();

            DoAnimalStuff(dog);
            DoAnimalStuff(cat);
        }

        static void DoAnimalStuff(Animal animal)
        {
            Console.WriteLine($"Animal name is {animal.Name}");
            animal.AnimalSound();
            animal.Sleep();
            Console.WriteLine();
        }
    }
}
