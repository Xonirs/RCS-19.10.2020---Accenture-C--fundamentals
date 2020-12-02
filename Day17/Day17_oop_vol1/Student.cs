using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_oop_vol1
{
    class Student
    {
        //private - the code (in this case the field name) can be ONLY accessed in the SAME CLASS (in this class)
        //private string name;

        //public - the code is accessible for all classes
        public string name;
        public int age;

        public List<int> grades = new List<int>();

        //constructor - the initialization method for a class object
        //by default (if not specified), the constructor is empty and parameter-less
        public Student()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A Student object was created!");
            Console.ResetColor();
        }

        public Student(string _name, int _age)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A Student object was created with parameters!");
            Console.ResetColor();

            name = _name;
            age = _age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student's name is {name} and age is {age}.");
            if (grades.Count > 0)
            {
                PrintGrades();
                Console.WriteLine($"Average grade: {GetAvgGrade()}");
            }
        }

        private void PrintGrades()
        {
            Console.WriteLine("Student's grades");
            foreach (var grade in grades)
            {
                Console.Write(grade + " ");
            }
            Console.WriteLine();
        }

        private double GetAvgGrade()
        {
            //sum all grades
            var sum = 0.0;
            foreach (var grade in grades)
            {
                sum += grade; //sum = sum + grade
            }

            //to get avg, we divide by count
            return sum / grades.Count;
        }
    }
}
