using System;
using System.Threading;

namespace Day23_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ChristmasTree tree = new ChristmasTree();
            tree.Type = TreeType.Silver;
            Console.WriteLine("Tree type: " + tree.Type);


            tree.Height = 75;
            tree.Width = 101;
            Console.WriteLine(tree.Height + " " + tree.Width);
            tree.PrintLocation();

            tree.LastPresent = "racing car";
            tree.LastPresent = "iPhone";
            tree.LastPresent = "toothbrush";
            tree.PrintAllPresents();
        }
    }
}
