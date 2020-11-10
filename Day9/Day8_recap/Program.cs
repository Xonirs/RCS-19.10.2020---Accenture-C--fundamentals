using System;

namespace Day8_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Peter", "Bob", "John", "George", "Mary" };

            #region Array test stuff

            //array length
            int namesLength = names.Length;

            //first element of array
            string firstWord = names[0];
            //third element of array
            string thirdWord = names[2];

            Console.WriteLine($"Array for names has {namesLength} elements. 1st - {firstWord}, 3rd - {thirdWord}");

            //third element value changing
            names[2] = "Ann";
            Console.WriteLine($"3rd array element after changing is {names[2]}");
            //Console.WriteLine($"3rd array element after changing is {thirdWord}");//prints John

            #endregion

            //Print all names
            Console.WriteLine("Printing all names:");
            int counter = 0;
            while (counter < names.Length)
            {
                Console.WriteLine($"Counter value:{counter}, array element of index {counter} is {names[counter]}");
                counter++;
            }
            Console.WriteLine($"Counter = {counter}");

            //Print all the names with length above 4
            Console.WriteLine("Printing names which have length above 4:");
            counter = 0;
            while (counter < names.Length)
            {
                string name = names[counter];
                if (name.Length > 4)
                {
                    Console.WriteLine($"The value {name} is above 4");
                }
                counter++;
            }

            //the same thing above, just without string variable name
            Console.WriteLine("Printing names which have length above 4, VOL2:");
            counter = 0;
            while (counter < names.Length)
            {                
                if (names[counter].Length > 4)
                {
                    Console.WriteLine($"The value {names[counter]} is above 4");
                }
                counter++;
            }

            //DO NOT REPEAT THIS AT HOME KIDS
            //while (names.Length > 4) //doesn't make sense to check if the array size is above 4. ARRAY SIZE WILL NEVER CHANGE!
            //{
            //}

        }
    }
}

//array printing, 8.4
