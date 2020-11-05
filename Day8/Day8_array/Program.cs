using System;

namespace Day8_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //array definition
            int[] scores = new int[] { 100, 98, 65, 43, 0, 100, 87 };
            //first value
            int firstValue = scores[0];
            Console.WriteLine(firstValue);
            Console.WriteLine(scores[3]);

            //DON'T DO THIS!!!!!!!!!
            Console.WriteLine(scores);
            //100 98 65 ...
            //1009865430100...
            //100;98;65;...
            //......

            //last value
            int lastValue = scores[scores.Length - 1];
            Console.WriteLine(lastValue);
            
            //array length
            int arrayLength = scores.Length;
            Console.WriteLine($"Array 'scores' length is {arrayLength}");

            //changing second value
            Console.WriteLine($"Second value of array is {scores[1]}");
            scores[1] = 77777777;
            Console.WriteLine($"Second value of array is {scores[1]}");
            Console.WriteLine();

            //printing all array elements
            int x = 0;
            while (x < arrayLength)
            {
                Console.WriteLine($"Counter:{x}, array value: {scores[x]}");
                x++;
            }

            Console.WriteLine();
            string[] names = new string[] { "Ann", "Bob", "Peter" };
            string secondName = names[1];
            Console.WriteLine($"Second name in the array is {secondName}");
        }
    }
}
