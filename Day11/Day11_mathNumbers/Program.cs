using System;

namespace Day11_mathNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Math with self
            int number = 10;

            number++; //adding 1
            number--; //subtracting 1
            Console.WriteLine(number);

            number = number + 5; //adding 5
            Console.WriteLine(number);

            number += 5; //adding 5, same as: number = number + 5
            Console.WriteLine(number);

            number *= 5; //multiplying by 5, same as: number = number * 5
            Console.WriteLine(number);

            number -= 5 * 3; //subtract 5*3, same as: number = number - 5*3
            Console.WriteLine(number);

            number *= number; //multiplying by number, same as: number = number * number
            Console.WriteLine(number);

            number /= 35; //dividing by 35, same as: number = number / 35
            Console.WriteLine(number);
            #endregion
            #region Division with double/int and Math.Round
            Console.WriteLine();

            int x = 11, y = 4;
            int z = x / y;
            Console.WriteLine(z); //technical result is 2.75, but since we use int data type (whole numbers), z = 2

            double a = 11, b = 4;
            double c = a / b;
            Console.WriteLine(c); //technical result is 2.75, but since we use double data type (numbers with decimal point), c = 2.75

            int d = 11;
            double e = 4;
            //int f = d / e; //this can't be an int result
            double f = d / e;
            Console.WriteLine(f);

            double g = 2.61;
            double h = Math.Round(g); //3
            Console.WriteLine(h);

            double i = 2.41;
            double j = Math.Round(i); //2
            Console.WriteLine(j);

            double k = 2.5;
            double l = Math.Round(k); //2
            Console.WriteLine(l);

            double m = 3.5;
            double n = Math.Round(m); //4
            Console.WriteLine(n);

            double o = 2.5;
            double p = Math.Round(o, MidpointRounding.AwayFromZero); //3
            Console.WriteLine(p);

            double q = 2.75;
            double r = Math.Round(q, 1, MidpointRounding.AwayFromZero); //2.8
            Console.WriteLine(r);

            #endregion
            #region Remainder %
            Console.WriteLine();

            //%
            //checks what is the remainder after the division of both numbers
            //10 divided by 4 = 2. Remainder = 2, because 4 * 2 = 8 and 10 - 8 = 2
            int bigNumber = 10;
            int smallNumber = 4;
            int remainder = bigNumber % smallNumber;
            Console.WriteLine(remainder);

            //63 divide by 9 = 7. Nothing is left because 9 * 7 = 63, so remainder is 0.
            int bigNumber2 = 63;
            int smallNumber2 = 9;
            int remainder2 = bigNumber2 % smallNumber2;
            Console.WriteLine(remainder2);

            #endregion

            Console.WriteLine();
            //two variables not needed for solution, yet good to know
            int intTypeMaxValue = Int32.MaxValue;
            int intTypeMinValue = Int32.MinValue;
            Console.WriteLine($"Int type max value: {intTypeMaxValue}");
            Console.WriteLine($"Int type min value: {intTypeMinValue}");
        }
    }
}
//
