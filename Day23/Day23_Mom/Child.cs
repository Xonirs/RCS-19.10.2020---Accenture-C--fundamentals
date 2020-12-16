using System;
using System.Collections.Generic;
using System.Text;

namespace Day23_Mom
{
    enum HairColor
    {
        Brown,
        Blonde,
        Blue,
        Green,
        Gray
    }


    //Child has properties – Name, Age, HairColor. 
    //Create an enum for HairColor. 
    class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public HairColor HairColor { get; set; }

        public Child(string name, int age, HairColor hairColor)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
        }
    }
}
