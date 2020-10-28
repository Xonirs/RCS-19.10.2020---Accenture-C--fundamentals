using System;

namespace Day4_if_training
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have to manage a party by sending people to their rooms. 
            //Oscar, Ann -> first room; 
            //Bobby, Mary -> second room
            //everyone else -> third room
            //Party people: Oscar, Ann, Bobby, Mary, John, Cristopher, Dwight, Alice, Ruth, Bill

            string person = "Ann"; 

            if (person == "Oscar" || person == "Ann")
            {
                Console.WriteLine("First room");
            }
            else if (person == "Bobby" || person == "Mary")
            {
                Console.WriteLine("Second room");
            }
            else 
            {
                Console.WriteLine("Third room");
            }


            //Playing a game.You are using a standard dice with 6 edges, with numbers 1-6. 
            //If you roll 1 or 2, you get 4 points, 
            //if you roll 3 or 4, you get 2 points,
            //if you roll 5 or 6, you get 1 point

            int number = 1;
            if (number == 1 || number == 2)
            {
                Console.WriteLine("You get 4 points");
            }
            else if (number == 3 || number == 4)
            {
                Console.WriteLine("You get 2 points");
            }
            else if (number == 5 || number == 6)
            {
                Console.WriteLine("You get 1 point");
            }
        }
    }
}
