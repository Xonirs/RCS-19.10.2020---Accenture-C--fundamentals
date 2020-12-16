using System;

namespace Day23_Movie
{
    // In Program.Main create new Movie object and 
    //fill all values via constructor. 
    //Print all the values (where it’s possible). 
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Avatar", 2009, 20, "James Cameron");
            Console.WriteLine($"Movie info:");
            Console.WriteLine($"{movie.Name} {movie.Year} " +
                $"{movie.Price}");
        }
    }
}
