using System;
using System.Collections.Generic;
using System.Linq;

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

            Student student1 = students.First(s => s.Age == 12);
            student1.PrintInfo();

            var student2 = students.FirstOrDefault(s => s.Name.StartsWith("J"));
            student2.PrintInfo();

            var student3 = students.FirstOrDefault(s => IsMagicPerson(s));
            student3.PrintInfo();
            bool isThirdStudentMagical = IsMagicPerson(students[2]);

            List<Student> jStudents = students.Where(s => s.Name.StartsWith("J")).ToList();
            Console.WriteLine("Here are all the students whose name start with a J");
            foreach (var stud in jStudents)
            {
                stud.PrintInfo();
            }

            List<Student> magicStudents = students.Where(s => IsMagicPerson(s)).ToList();
            Console.WriteLine("Here are all the students who are MAGICAL>>>>>");
            foreach (var stud in magicStudents)
            {
                stud.PrintInfo();
            }

            //getting all students who have at least 1 grade equal to 10
            List<Student> gStudents = students.Where(s => s.Grades.Any(g => g == 10)).ToList();
            Console.WriteLine("Here are all the students who have at least a single grade 10");
            foreach (var stud in gStudents)
            {
                stud.PrintInfo();
            }

            //getting all students who have all the grades above 4
            List<Student> gStudents2 = students.Where(s => s.Grades.All(g => g > 4)).ToList();
            Console.WriteLine("Here are all the students whose all grades are above 4");
            foreach (var stud in gStudents2)
            {
                stud.PrintInfo();
            }
        }

        static bool IsMagicPerson(Student student)
        {
            return student.Age > 20 && student.Address.Contains("Riga");
        }
    }
}
