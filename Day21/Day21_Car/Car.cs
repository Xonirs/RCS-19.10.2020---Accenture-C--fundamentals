using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_Car
{
    //Create a class Car. Create a public method – void PressHorn(), 
    //which will print out a message to console “Honk honk”. 
    //Create a private field – hornPressedCount. Its initial value will be zero 
    //and it will increase each time method PressHorn is called. 
    //Create a public method – string GetHornCount(), 
    //which will return a message $“Car horn was pressed {hornPressedCount}”. 
    class Car
    {
        private int hornPressedCount = 0;

        public void PressHorn()
        {
            Console.WriteLine("Honk honk");
            hornPressedCount++;
        }

        public string GetHornCount()
        {
            return $"Car horn was pressed {hornPressedCount}";
        }
    }
}
