using System;

namespace Day12_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region var examples
            //var - enables us to define ANY kind of value of ANY data type
            var number = 10; //will be int
            var name = "Bob"; //will be string
            var isItDark = true; //will be bool
            var salary = 834.99; //will be double

            //var randomVariable; //this will NOT WORK. when using var, we must always assign value

            //var input = Console.ReadLine();
            //var inputNumber = int.Parse(input);

            //instead of string[] familyNames = new string[10];, we can do this:
            var familyNames = new string[10];
            #endregion

            //foreach loop is useful, when we want to iterate through values, 
            //but don't want to know their position or don't want to CHANGE them

            var relativeNames = new string[] { "Bob", "Ann", "Alice", "Peter", "John" };
            //string relative - foreach loop built in variable, which will represent every element of collection
            //relativeNames - array or a collection we are going to iterate 
            foreach (string relative in relativeNames)
            {
                //with foreach loop, we can READ values from a collection
                Console.WriteLine(relative);

                //with foreach loop, we CAN'T WRITE/CHANGE values from a collection
                //relative = "Ted"; //WILL NOT WORK
            }


            int[] grades = { 100, 0, 0, 100, 100, 0 };
            int gradeSum = 0;
            foreach (int grade in grades)
            {
                gradeSum += grade; //equals to: gradeSum = gradeSum + grade;
                string magic = Console.ReadLine();
                if (magic == "abrakadabra" || grade == 100)
                {
                    //...
                }
            }
            Console.WriteLine($"Grade sum {gradeSum}");
            
        }
    }
}
