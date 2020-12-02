using System;

namespace Day17_oop_vol1
{
    class Program
    {
        //...entry point for Console applications
        static void Main(string[] args)
        {
            #region null value
            //if a class object (variable) is not initialized, then it has no value
            //for classes to NOT HAVE A VALUE - null
            //null - a non-existing value. similar to "nothing"
            Student testStudent; //the same as -> Student testStudent = null;
            testStudent = null;
            //testStudent.PrintInfo(); //error
            if (testStudent == null)
            {
                Console.WriteLine("testStudent object is a NON EXISTING VALUE");
            }

            testStudent = new Student();
            if (testStudent == null) //will be false
            {
                Console.WriteLine("testStudent object is a NON EXISTING VALUE");
            }
            else
            {
                testStudent.name = "TestName";
                testStudent.age = 12;
                testStudent.PrintInfo();
            }
            #endregion

            Student student = new Student();
            //does nothing, just prints {namespace}.{className}
            Console.WriteLine(student);

            student.name = "Bob";
            Console.WriteLine(student.name);
            student.name = "Peter";
            student.age = 21;
            Console.WriteLine(student.name);
            Console.WriteLine(student.age);

            Student student2 = new Student();
            student2.name = "Ann";
            student2.age = 25;
            Console.WriteLine(student2.name);
            Console.WriteLine(student2.age);

            student.PrintInfo();
            student2.PrintInfo();

            student.grades.Add(8);
            student.grades.Add(6);
            student.grades.Add(9);
            student.grades.Add(4);
            student.grades.Add(7);

            student.PrintInfo();

            Student student3 = new Student("Sarah", 27);
            student3.PrintInfo();
        }
    }
}
