using System;

namespace Day25_sealed_real
{
    //sealed class:
    //if you don't want other classes to inherit from a class, use sealed
    sealed class Human
    {

    }

    //because of sealed this is not possible
    //class Male : Human 
    class Male
    {

    }

    class BaseClass { public virtual void Print() { Console.WriteLine("Printing virtual method"); } }

    class DerivedClass : BaseClass
    {
        //this mneans that the Print() method have been sealed and it can't be overriden
        public override sealed void Print()
        {
            Console.WriteLine("Printing sealed method");
        }
    }

    class ThirdClass : DerivedClass
    {
        //This cannot happen because of the sealed keyword
        //public override void Print()
        //{
        //    //...
        //    Console.WriteLine("Third class override");
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new ThirdClass(); bc.Print();
        }
    }
}
