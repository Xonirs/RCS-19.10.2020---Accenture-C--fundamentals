using System;

namespace Day7_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 10)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine();

            //break - exits the loop immediately
            int n1 = 0;
            while (n1 < 10)
            {
                if (n1 == 8)
                {
                    break; //at this point, loop has been stopped
                }

                Console.WriteLine(n1);
                n1++;
            }
            Console.WriteLine($"Loop has ended, N = {n1}");
            Console.WriteLine();
            //continue - jumps to the next loop iteration thus skipping everything left in the current one
            int n2 = 0;
            while (n2 < 20)
            {
                if (n2 == 8 || n2 == 14 || n2 == 16)
                {
                    n2++;
                    continue; //at this point this iteration stops and next one begins
                }

                Console.WriteLine(n2);                
                n2++;
            }
            Console.WriteLine($"Loop has ended, N = {n2}");
        }
    }
}
