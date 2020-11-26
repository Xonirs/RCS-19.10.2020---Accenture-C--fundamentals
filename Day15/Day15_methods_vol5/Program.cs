using System;
using System.Collections.Generic;

namespace Day15_methods_vol5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> relativeNames = GetRelativeNames();
            PrintList(relativeNames);
        }

        static List<string> GetRelativeNames()
        {
            var resultList = new List<string>();

            resultList.Add("Ann");
            resultList.Add("Peter");
            resultList.Add("Mary");

            return resultList;
        }

        static void PrintList(List<string> list)
        {
            foreach (string listItem in list)
            {
                Console.WriteLine(listItem);
            }
        }
    }
}
