using System;
using System.Collections.Generic;

namespace Day19_simpleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ - language integrated query

            List<string> names = new List<string>() { "John", "Ann", "Cecilia", "Bob", "Christopher", "Magnolia" };

            //task: does the list contain a value of 'Bob'
            //old way, without built-in functionality
            bool isBobInTheList = false;
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == "Bob")
                {
                    isBobInTheList = true;
                }
            }

            //new way, using built-in functionality
            bool isBobInTheList_new = names.Contains("Bob");

            List<Person> familyMembers = new List<Person>(); 
            Person person1 = new Person("John", "Peterson", 12, ConsoleColor.Red, true);
            familyMembers.Add(person1);
            familyMembers.Add(new Person("Billy", "Tree", 56, ConsoleColor.Yellow, false));
            familyMembers.Add(new Person("Sally", "Hufflepuff", 34, ConsoleColor.Red, true));
            familyMembers.Add(new Person("Sarah", "Chairman", 17, ConsoleColor.Yellow, true));
            familyMembers.Add(new Person("Peter", "Ball", 46, ConsoleColor.Green, false));
            familyMembers.Add(new Person("Nomadix", "Gamester", 25, ConsoleColor.Blue, false));

            //task:get the first person you can find, who has age above 30
            //old way: without linq

            //defining the end result. if we find none, the value remains
            //null, which is the default value for class objects
            Person personWithAgeAbove30 = null;
            //let's go through all the family members
            for (int i = 0; i < familyMembers.Count; i++)
            {
                //if a family member's age is above 30
                if (familyMembers[i].Age > 30)
                {
                    //we have found what we wanted, exiting loop
                    //since we found somebody older than 30 years, 
                    //we assign this value to the new variable 'personWithAgeAbove30'
                    personWithAgeAbove30 = familyMembers[i];
                    break; //exiting loop, we wanted to find the first one
                }
            }

            if (personWithAgeAbove30 != null) //checking if we found
            {
                personWithAgeAbove30.PrintInfo();
            }
            else
            {
                Console.WriteLine("such a person was not found");
            }
            
            //new way: with linq
        }
    }
}
