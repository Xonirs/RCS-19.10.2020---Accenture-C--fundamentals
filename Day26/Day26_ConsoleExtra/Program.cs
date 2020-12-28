using System;
using System.Threading;

namespace Day26_ConsoleExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console.Clear
            //PrintRandomStuff();
            //string test = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("test test 1234567890");
            #endregion
            #region Console.ReadKey
            //Console.WriteLine("Please enter any key:");
            //var key = Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine($"You pressed: Key - {key.Key}, KeyChar - {key.KeyChar}");

            //ConsoleKey keyPressed = Console.ReadKey().Key;
            //if (keyPressed == ConsoleKey.RightArrow)
            //{
            //    Console.WriteLine("You pressed the right arrow");
            //}
            //else
            //{
            //    Console.WriteLine($"You printed something else. You typed: {keyPressed}");
            //}
            #endregion
            #region Console.SetCursorPostion
            //Console.WriteLine("FIRST");
            //Console.SetCursorPosition(10, 10);
            //Console.WriteLine("SECOND");
            //Console.WriteLine("THIRD");
            //Console.SetCursorPosition(11, 11);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("FOURTH");
            //Console.ResetColor();
            //Console.SetCursorPosition(15, 11);
            //Console.WriteLine("overwrite");
            #endregion
            #region Console.Beep
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Beep();
            //}
            //for (int i = 37; i < 300; i+=20)
            //{
            //    Console.Beep(i, 100);
            //}
            #endregion
            #region Thread.Sleep
            //PrintRandomStuff();
            //Thread.Sleep(2500);
            //PrintRandomStuff("b");
            #endregion
            #region Console.KeyAvailable
            while (true)
            {
                Console.WriteLine("Press z to exit");
                int count = 0;
                while (!Console.KeyAvailable) //Console.KeyAvailable is true when there is a key input to be read
                {
                    //Loop until input is entered
                    Thread.Sleep(150);
                    Console.WriteLine(count++);
                }

                ConsoleKey keyPressed = Console.ReadKey().Key;
                Console.WriteLine($"You pressed {keyPressed}");
                if (keyPressed == ConsoleKey.Z)
                {
                    break;
                }
            }
            #endregion
        }

        static void PrintRandomStuff(string letter = "a")
        {
            for (int i = 0; i < 500; i++)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}
