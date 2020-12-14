using System;
using System.Collections.Generic;

namespace Day22_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("John", "Bon", 12, "Riga, main street 23", new List<int>() {4,4,4}));
            students.Add(new Student("Ann", "Malkovich", 23, "Riga, other street 45", new List<int>() {10,10,10}));
            students.Add(new Student("Joshua", "Sonma", 45, "Cesis, 2nd street 78", new List<int>() {7,8,9}));
            students.Add(new Student("Milly", "Portis", 7, "Cesis, main street 98", new List<int>() {8,8,7,7}));
            students.Add(new Student("Bob", "Kerm", 27, "Riga, bush street 5", new List<int>() {3}));
            students.Add(new Student("Peter", "Stevens", 38, "Jelgava, tree street 1", new List<int>() {5,3,10}));
        }
    }
}
