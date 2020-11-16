using System;
using System.Collections.Generic; //works for the WHOLE FILE

namespace Day12_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList;
            //currently the numberList is NON-EXISTING
            //usage will resolve in an error

            //numberList.Add(1); will not work, variable not assigned to a new list object
            numberList = new List<int>();

            List<int> testNumberList = new List<int>();

            //adding an element
            numberList.Add(50);
            int testNumber = 70;
            numberList.Add(testNumber);

            List<string> carBrands = new List<string>();
            carBrands.Add("audi");
            carBrands.Add("bmw");
            Console.WriteLine("Please input 2 cars:");
            carBrands.Add(Console.ReadLine());
            string carInput = Console.ReadLine();
            carBrands.Add(carInput);

            int carCount = carBrands.Count;
            Console.WriteLine($"There are {carCount} cars!");

            carBrands.Add("vw");
            carBrands.Add("opel");

            Console.WriteLine($"There are {carBrands.Count} cars!");

            string firstCar = carBrands[0];
            Console.WriteLine($"First car is {firstCar}");
            string lastCar = carBrands[carBrands.Count - 1];
            Console.WriteLine($"Last car is {lastCar}");

            Console.WriteLine("Here are all the cars:");
            for (int i = 0; i < carBrands.Count; i++)
            {
                Console.WriteLine(carBrands[i]);
            }

            Console.WriteLine("Here are all the cars, VOL 2:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("Removing some cars from the list");

            //removing without a bool result
            carBrands.Remove("opel");
            carBrands.Remove("jeep");

            //removing with a bool result which specifies if anything was removed
            bool removal1 = carBrands.Remove(firstCar); // true, because audi existed in the list and could be removed
            Console.WriteLine($"Attempting to remove {firstCar} from the list. Was the value removed: {removal1}");

            bool removal2 = carBrands.Remove("mini"); // false, because nothing was removed
            Console.WriteLine($"Attempting to remove mini from the list. Was the value removed: {removal2}");

            Console.WriteLine("Here are all the cars, VOL 3:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            var testCars = new List<string> { "ferrari", "honda", "suzuki" };
            Console.WriteLine("Adding multiple cars to the list...");
            //adding multiple cars at the same time
            carBrands.AddRange(testCars);

            Console.WriteLine("Here are all the cars, VOL 4:");
            foreach (string car in carBrands)
            {
                Console.WriteLine(car);
            }

            //clears all elements from the list
            testCars.Clear();
        }
    }
}
