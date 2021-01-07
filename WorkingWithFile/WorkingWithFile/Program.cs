using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkingWithFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\LACJAN\source\repos\RCS-19.10.2020---Accenture-C--fundamentals\WorkingWithFile\WorkingWithFile\myTextFile.txt";
            string filePath2 = @"C:\Users\LACJAN\source\repos\RCS-19.10.2020---Accenture-C--fundamentals\WorkingWithFile\WorkingWithFile\myTextFileStreamWriter.txt";

            #region writing to a text file
            //creates a new file, if it doesn't exist
            //or overwrites content if it exists
            File.WriteAllText(filePath, "this is my content");

            //if no path specified, then it creates a new file where the *.exe file is created
            File.WriteAllText("testText.txt", "this is my content VOL2");

            string someText = "first text";
            someText += " second text";
            someText += "\n"; //adding a new line
            someText += " third text";
            someText += Environment.NewLine; //adding a new line
            someText += "fourth text";
            File.WriteAllText("someTextFile.txt", someText);

            string[] someLines = { "first line", "second line", "third line" };
            File.WriteAllLines("testAllLinesArray.txt", someLines);
            List<string> someLinesList = someLines.ToList();
            File.WriteAllLines("testAllLinesList.txt", someLinesList);

            File.AppendAllLines("testAllLinesList.txt", someLinesList);

            using (StreamWriter file = new StreamWriter(filePath2))
            //using (StreamWriter file = new StreamWriter(filePath2, true)) //true - means to append to a file, not overwrite
            {
                file.WriteLine("File begins");

                for (int i = 0; i < 100; i++)
                {
                    if (i % 17 == 0)
                    {
                        file.Write(i + " ");
                    }
                }
                file.WriteLine();

                file.WriteLine("file ends============");
            }
            #endregion

            #region reading from a text file
            string text1 = File.ReadAllText(filePath2);
            Console.WriteLine(text1);
            Console.WriteLine();

            string[] textLines1 = File.ReadAllLines(filePath2);
            Console.WriteLine($"These are all the text lines in the file '{filePath2}':");
            foreach (var item in textLines1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //numbers are on the 2nd line
            string[] splitValues = textLines1[1].Split(" "); //specifying that the values are separated by a space
            Console.WriteLine("Here are all the numbers 1 by 1:");
            foreach (var item in splitValues)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
