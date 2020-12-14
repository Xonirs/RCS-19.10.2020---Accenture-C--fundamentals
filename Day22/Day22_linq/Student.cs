using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_linq
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public Student(string name, string surname,
            int age, string address, List<int> grades)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Address = address;
            Grades = grades;
        }
    }
}
