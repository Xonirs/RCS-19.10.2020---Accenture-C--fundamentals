using System;

namespace Day25_poly
{
    //Polymorphism - "many shapes/forms". it allows to perform a single action in different ways
    //virtual - this allows for the member to be overriden in a derived class
    //override - this allows to modify the original implementation from inherited member

    class Animal
    {
        public int EyeCount { get; set; }
        public virtual void AnimalSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    class Rooster : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("cock-a-doodle-doo");
        }
    }

    class Dog : Animal
    {
        public string HairColor { get; set; }
        public override void AnimalSound()
        {
            Console.WriteLine("WoofWoofWoof");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(); animal.AnimalSound();
            Dog dog = new Dog(); dog.AnimalSound();
            dog.HairColor = "black";
            dog.EyeCount = 2;
            Rooster rooster = new Rooster(); rooster.AnimalSound();

            Animal dogAnimal = new Dog(); dogAnimal.AnimalSound();
        }
    }
}
