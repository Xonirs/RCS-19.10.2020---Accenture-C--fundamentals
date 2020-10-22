using System;

namespace Day2_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This text will be printed");
            Console.WriteLine();

            Console.WriteLine("Simple variable stuff:");
            string name = "John";
            int age = 54;
            double salary = 450.00;
            bool didIhaveBreakfast = false;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(salary);
            Console.WriteLine(didIhaveBreakfast);
            Console.WriteLine();

            //string name = "Dave"; //this won't work, can't have duplicate variable name
            name = "Dave";
            Console.WriteLine(name);

            bool itWillSnowTomorrow;
            //....
            Console.WriteLine("Weather predictor says it will snow tomorrow");
            itWillSnowTomorrow = true;

            int number = 37;
            int otherNumber = 12;
            int sum = number + otherNumber;
            Console.WriteLine(sum);

            Console.WriteLine("How to read from console:");
            Console.WriteLine("Please enter your name:");
            string userNameInput = Console.ReadLine(); //from CONSOLE we can read ONLY text values

            Console.WriteLine("Please enter your surname:");
            string userSurnameInput = Console.ReadLine();

            string userIdentity = userNameInput + " " + userSurnameInput;
            Console.WriteLine(userIdentity);
            Console.WriteLine(userNameInput + " " + userSurnameInput);
            Console.WriteLine();
            
            string userIdentity2 = $"{userNameInput} {userSurnameInput}";
            Console.WriteLine(userIdentity2);
            Console.WriteLine($"{userNameInput} {userSurnameInput}");

            string userIdentity3 = string.Format("{0} {1}", userNameInput, userSurnameInput);
            Console.WriteLine(userIdentity3);
            Console.WriteLine(string.Format("{0} {1}. Color: {2}. {0} {1}. Age: {3}", userNameInput, userSurnameInput, "red", 24));


            Console.WriteLine("END OF CODE");
        }
    }
}

