using System;
using System.Collections.Generic;
using System.Text;

namespace Day25_ant
{
    //Ant has public properties - Name, Size, and a public method void WorkerSound(), which prints “WORK WORK WORK”.
    class Ant
    {
        public int Size { get; set; }
        public string Name { get; set; }

        public void WorkerSound()
        {
            Console.WriteLine("WORK WORK WORK");
        }
    }
}
