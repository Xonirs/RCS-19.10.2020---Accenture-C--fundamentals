using System;
using System.Collections.Generic;
using System.Linq;

namespace Day23_Mom
{
    class Program
    {
        //In Program.Main create new Mom object. Create multiple Child objects and add to the list of Mom.Children. Using LINQ:
        //1.	Get all the children above age 5.
        //2.	Get all the children with brown hair color
        //3.	Get the first children in the list with the name “Bob”
        //4.	Get all the children whose name Contains letter “e”
        //After each usage of LINQ, print the results.
        static void Main(string[] args)
        {
            Mom myMom = new Mom();
            var child1 = new Child("Bob", 3, HairColor.Brown);
            myMom.Children.Add(child1);
            myMom.Children.Add(new Child("Ann", 6, HairColor.Blue));
            myMom.Children.Add(new Child("Peter", 3, HairColor.Brown));
            myMom.Children.Add(new Child("Ernest", 13, HairColor.Gray));
            myMom.Children.Add(new Child("Marry", 23, HairColor.Green));

            List<Child> oldChildren = myMom.Children.Where(x => x.Age > 5).ToList();
            PrintChildrenInfo(oldChildren, "Here are children above age 5:");

            List<Child> brownColorChildren = myMom.Children.Where(test => test.HairColor == HairColor.Brown).ToList();
            PrintChildrenInfo(brownColorChildren, "Here are children with brown hair:");

            Child bobChild = myMom.Children.FirstOrDefault(child => child.Name == "Bob");
            PrintChildrenInfo(bobChild, "Here is a child named Bob:");

            List<Child> eChildren = myMom.Children.Where(c => c.Name.Contains("e")).ToList();
            PrintChildrenInfo(eChildren, "Here are children whose name contains 'e':");

        }

        private static void PrintChildrenInfo(List<Child> children, string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            foreach (var child in children)
            {
                Console.WriteLine("Here is the child's info:");
                Console.WriteLine($"Name: {child.Name}");
                Console.WriteLine($"Age: {child.Age}");
                Console.WriteLine($"HairColor: {child.HairColor}");
                Console.WriteLine();
            }
        }

        private static void PrintChildrenInfo(Child child, string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
           
            Console.WriteLine("Here is the child's info:");
            Console.WriteLine($"Name: {child.Name}");
            Console.WriteLine($"Age: {child.Age}");
            Console.WriteLine($"HairColor: {child.HairColor}");
            Console.WriteLine();
        }
    }
}
