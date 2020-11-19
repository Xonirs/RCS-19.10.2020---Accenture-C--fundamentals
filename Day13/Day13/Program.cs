using System;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2d = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            Console.WriteLine("Printing 2d array values vol.1:");
            for (int i = 0; i < array2d.GetLength(0); i++) //i - represents the subarrays
            {
                for (int j = 0; j < array2d.GetLength(1); j++) //j - represents the values in the subarrays
                {
                    Console.WriteLine($"[{i},{j}] = {array2d[i, j]}");
                }
            }

            array2d[2, 1] = 9899;

            Console.WriteLine("Printing 2d array values vol.2:");
            for (int i = 0; i < array2d.GetLength(0); i++) //i - represents the subarrays
            {
                for (int j = 0; j < array2d.GetLength(1); j++) //j - represents the values in the subarrays
                {
                    Console.WriteLine($"[{i},{j}] = {array2d[i, j]}");
                }
            }
                        
            string[,] kalerija2d = new string[4,3] { { "Tom", "100", "32" }, { "Ann", "110", "31" }, { "Mary", "105", "35" }, { "John", "108", "25" } };
            Console.WriteLine("Kalerija's 2d array:");
            for (int i = 0; i < kalerija2d.GetLength(0); i++) //i - represents the subarrays
            {
                for (int j = 0; j < kalerija2d.GetLength(1); j++) //j - represents the values in the subarrays
                {
                    Console.WriteLine($"[{i},{j}] = {kalerija2d[i, j]}");
                }
            }

            Console.WriteLine("Kalerija's 2d array vol.2:");
            for (int i = 0; i < kalerija2d.GetLength(0); i++) //i - represents the subarrays
            {                
                Console.WriteLine($"Name = {kalerija2d[i, 0]}, Height = {kalerija2d[i, 1]}, Weight = {kalerija2d[i, 2]},");
            }

            
            //3D arrays

            int[,,] array3d = new int[4, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, 
                                                 { { 7, 8 }, { 9, 10 }, { 11, 12 } }, 
                                                 { { 13, 14 }, { 15, 16 }, { 17, 18 } }, 
                                                 { { 19, 20 }, { 21, 22 }, { 23, 24 } } };

            Console.WriteLine("Printing 3d array values vol.1:");
            for (int i = 0; i < array3d.GetLength(0); i++) //i - represents the subarrays
            {
                for (int j = 0; j < array3d.GetLength(1); j++) //j - represents the values in the subarrays
                {
                    for (int z = 0; z < array3d.GetLength(2); z++)
                    {
                        Console.WriteLine($"[{i},{j},{z}] = {array3d[i, j, z]}");
                    }
                }
            }

        }
    }
}
