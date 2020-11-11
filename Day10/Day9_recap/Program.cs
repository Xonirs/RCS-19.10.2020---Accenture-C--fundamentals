using System;

namespace Day9_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            #region loops + arrays
            #region Loops

            //while loop
            bool testBool = true;
            while (testBool)
            {
                Console.WriteLine("a");
                string userInput = Console.ReadLine();
                if (userInput == "stop")
                {
                    testBool = false;
                }
            }

            //do while
            int counter = 53;
            do
            {
                Console.WriteLine("b");
                counter++;
            } while (counter < 58);


            //for loop
            //used for specific amount of times
            for (int counterBazoom = 0; counterBazoom < 10; counterBazoom++)
            {
                Console.WriteLine(counterBazoom);
            }
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //WHICH LOOP TO USE IN WHICH SCENARIO (looking for the best suited option)
            //Answer this question: do you know how many times the loop needs to execute?
            //YES -> for
            //NO -> while/do..while

            Console.WriteLine();
            #endregion

            #region Arrays

            //an array of data type double, with a possibility to store NO elements
            //there is no use for this defintion, but it is possible to do it
            double[] taxes = new double[] { };
            //Console.WriteLine(taxes[0]); //WILL NOT WORK, WE DEFINED AN ARRAY WITH NO ELEMENTS

            //an array of data type bool, with a possibility to store 7 elements.
            //this is an example to create an array with no values, but with space for values
            bool[] workDays = new bool[7];
            Console.WriteLine(workDays[0]); //nothing inside the first element, thus default value -> FALSE is printed
            Console.WriteLine("Do you have to work on Tuesdays?");
            string tuesdayInput = Console.ReadLine();
            workDays[1] = bool.Parse(tuesdayInput);
            Console.WriteLine($"Does this person need to work on Tuesdays: {workDays[1]}");

            //an array of data type int, with a possibility to store 5 elements.
            int[] numbers = new int[5];
            //assuming we don't know what is a loop
            //since array has no specific values, we are printing default int values -> 0
            Console.WriteLine($"Here are all the array numbers elements: {numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]} {numbers[4]} ");
            numbers[1] = 777;
            numbers[3] = 8;
            numbers[4] = -111;
            //assuming we don't know what is a loop
            Console.WriteLine($"Here are all the array numbers elements: {numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]} {numbers[4]} ");
            int secondNumber = numbers[1];
            Console.WriteLine($"The second number is {secondNumber} and also {numbers[1]}");


            //an array of data type string, with a possibility to store 5 elements.
            string[] carBrands = new string[] { "audi", "volkswagen", "dacia", "lexus", "ford" };
            //Length - the value of how many elements in the array
            int carBrandCount = carBrands.Length;
            Console.WriteLine($"We have information about {carBrandCount} cars.");
            //array + while loop
            int carWhileCounter = 0;
            while (carWhileCounter < carBrandCount)
            {
                //in each loop iteration we are going to look at a different array element, 
                //since the counter serves as the index and it changes by 1 every iteration
                Console.WriteLine($"Car nr.{carWhileCounter}");
                Console.WriteLine(carBrands[carWhileCounter]);
                carWhileCounter++;
            }

            //array + for loop
            Console.WriteLine();
            for (int i = 0; i < carBrandCount; i++)
            {
                Console.WriteLine(carBrands[i]);
            }

            #endregion
            #endregion


        }
    }
}

