using System;

namespace Day5_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sleptWell = false;
            string message = "sleptWell";

            if (sleptWell)
            {
                //we slept well last night with a different comment
                Console.WriteLine("B");                
            }

            if (sleptWell == true) //same thing as above and this way is NOT recommended
            {
                //we slept well last night
                Console.WriteLine("A");
            }

            int number = 10;
            double temp = 20.1;
            if ((number > 10 && sleptWell) || temp < 20.2)
            {
                Console.WriteLine("C");
            }

            //!
            //exclamation mark turn a bool value to the opposite, !true -> false, !false -> true
            bool winterIsComing = false;
            if (!winterIsComing) // IF winter is NOT coming
            {
                Console.WriteLine("D");
            }

            if (number != 7 || !winterIsComing)
            {

            }

            bool hungry = false; // we are not hungry
            string name = "Ann"; // somebody is called Ann
            //The first part: NOT-hungry, hungry is false -> true
            //The second part: name not equal to Bob -> true
            //Both parts: true AND true -> true
            bool test1 = !hungry && name != "Bob"; 
            //opposite value of test1, true -> false
            bool test2 = !test1;
            Console.WriteLine(test2); //false

            //string.IsNullOrEmpty - checks whether the string value is non-existing OR empty
            Console.WriteLine("Please enter your street name:");
            string street = Console.ReadLine();

            if (!string.IsNullOrEmpty(street)) //checking if street variable value is NOT empty
            {
                Console.WriteLine($"You entered - {street}");
            }

            string ageInput = "30";
            int age = int.Parse(ageInput); 

            string salaryInput = "901.56";
            double salary = double.Parse(salaryInput);

            string darkInput = "true";
            bool isItDark = bool.Parse(darkInput);


        }
    }
}
