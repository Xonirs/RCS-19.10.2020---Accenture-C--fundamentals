using System;
using System.Collections.Generic;

namespace Day12_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            numberList.Add(4);
            numberList.Add(44);
            numberList.Add(444);
            numberList.Add(4444);
            Console.WriteLine($"List has {numberList.Count} elements.");

            int firstListNumber = numberList[0];
            int lastListNumber = numberList[numberList.Count - 1];
            Console.WriteLine($"First element is {firstListNumber} and the last is {lastListNumber}.");

            Console.WriteLine("List printed:");
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }

            Console.WriteLine("List printed vol.2:");
            foreach (int number in numberList)
            {
                Console.Write($"{number} ");

                //THIS WILL NOT WORK
                //number = 99;
            }
            Console.WriteLine();

            Console.WriteLine("List printed vol.3:");
            int listCount = numberList.Count;
            for (int i = 0; i < listCount; i++)
            {
                string result = numberList[i].ToString(); //$"{numberList[i]}"

                if (i == listCount - 1) //checking if this is the last iteration
                {
                    result += "."; //ending with dot
                }
                else //if it is NOT the last iteration
                {
                    result += ", "; //end with comma and a space
                }
                
                Console.Write(result);
            }
            Console.WriteLine();

            numberList.Add(77);
            numberList.Add(778);
            numberList.Add(7790);

            numberList.Remove(3);
            numberList.Remove(4);

            bool removalSuccess = numberList.Remove(33);
            bool removalSuccess2 = numberList.Remove(44);
            Console.WriteLine($"We tried to remove 33, success : {removalSuccess}");
            Console.WriteLine($"We tried to remove 44, success : {removalSuccess2}");

            Console.WriteLine("List printed vol.4:");
            foreach (int number in numberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            numberList.RemoveAt(3);

            Console.WriteLine("List printed vol.5:");
            foreach (int number in numberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}


