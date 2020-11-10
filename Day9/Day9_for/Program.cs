using System;

namespace Day9_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //for - loop which is meant to be execute specific amount of times
            //      oppose to while - loop which can have any condition, thus the most flexible loop
            //int i = 0; - inner counter variable defintion, starting value can be any number, in example: 0
            //i < 10; - the condition which must be true to go to next iteration
            //i++ - how the inner counter value increases AFTER each iteration
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 10; i < 21; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 100; i > 89; i--)
            {
                Console.WriteLine(i);
            }

            //inner variable i doesn't exist outside the loop
            //Console.WriteLine($"i:{i}");
            Console.WriteLine();
            for (int i = -10; i > -17; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int[] ages = { 22, 25, 47, 13, 4, 87 };
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] > 24)
                {
                    Console.WriteLine($"Age: {ages[i]}, this person most likely has finished university!"); 
                }
                else
                {
                    Console.WriteLine($"Age: {ages[i]}");
                }
            }
            Console.WriteLine();

            string[] textValues = new string[4];
            for (int i = 0; i < textValues.Length; i++)
            {
                Console.WriteLine($"Index:{i}, Value:{textValues[i]}");
            }
            Console.WriteLine("Adding values");
            textValues[0] = "Table";
            textValues[2] = "Chair";
            for (int i = 0; i < textValues.Length; i++)
            {
                Console.WriteLine($"Index:{i}, Value:{textValues[i]}");
            }

            Console.WriteLine();
            string[] randomStrings = new string[4];
            //this loop will enter the values into the array
            for (int i = 0; i < randomStrings.Length; i++)
            {
                randomStrings[i] = "TEST" + i; //enter any value
            }

            //this loop will print the values from the array
            for (int i = 0; i < randomStrings.Length; i++)
            {
                Console.WriteLine(randomStrings[i]);
            }
        }
    }
}
