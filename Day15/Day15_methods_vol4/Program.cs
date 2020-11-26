using System;

namespace Day15_methods_vol4
{
    class Program
    {
        static void Main(string[] args)
        {
            string foodCriticism = GetFoodCritique("burger");
            Console.WriteLine($"Your thoughts about burgers - {foodCriticism}");
            string drinkCriticism = GetDrinkCritique("water");
            Console.WriteLine($"Your thoughts about water - {drinkCriticism}");
        }

        //the most important part - EACH path of code must HAVE a return statement
        static string GetDrinkCritique(string drink)
        {
            if (drink == "coke")
            {
                return "you don't like coca-cola";
            }
            else if (drink == "water")
            {
                return "you love water";
            }
            else
            {
                return $"you have no preference on {drink}";
            }
        }

        static string GetFoodCritique(string food)
        {
            string result = "";

            if (food == "burger")
            {
                result = "you don't like burgers";
            }
            else if (food == "cookies")
            {
                result = "you love cookies";
            }
            else
            {
                result = $"you have no preference on {food}";
            }

            return result;
        }
    }
}
