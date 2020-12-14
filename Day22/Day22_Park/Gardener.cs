using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_Park
{
    //Gardener has properties – Name, Experience, Age.
    class Gardener
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }

        public Gardener(string n, int a, int e)
        {
            Name = n;
            Age = a;
            Experience = e;
        }
    }
}
