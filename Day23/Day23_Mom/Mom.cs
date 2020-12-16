using System;
using System.Collections.Generic;
using System.Text;

namespace Day23_Mom
{
    //Mom has properties – Name, Children.
    //Children is a public List<Child>.
    class Mom
    {
        public string Name { get; set; }
        public List<Child> Children { get; set; } = new List<Child>();
    }
}
