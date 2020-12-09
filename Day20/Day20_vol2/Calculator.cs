using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_vol2
{
    //static means something which is not associated with an object. it cannot be instantiated.
    //you cannot create an object of a static class
    //in a static class, you can only create static members
    //you cannot access static class members using an object
    static class Calculator
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
