using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_oop_vol2
{
    class Concert
    {
        public string Artist;
        public string Venue;
        public int Seats;
        public double TicketPrice;
        public string City = "DEFAULT CITY";
        public string Name;
        public int ExpectedDuration;
        //date
        public DateTime Date;
        //audience
        private List<Visitor> Visitors = new List<Visitor>();

        public Concert()
        {

        }

        public void PrintConcertInfo()
        {
            Console.WriteLine("This is the concert info:");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Venue: {Venue}");
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Ticket Price: {TicketPrice}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"ExpectedDuration: {ExpectedDuration}");
            Console.WriteLine($"Visitor count: {Visitors.Count}");
            foreach (Visitor item in Visitors)
            {
                item.PrintInfo();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Attempting to add a new visitor to the concert.
        /// Applying multiple validations whether the visitor can enter.
        /// </summary>
        /// <param name="fullName">Visitor's full name</param>
        /// <param name="age">Visitor's age</param>
        /// <param name="money">Visitor's money for ticket</param>
        /// <param name="hasMask">Whether vistor has a mask</param>
        /// <returns>Message whether the visitor was let in or not.</returns>
        public string AddVisitor(string fullName, int age, double money, bool hasMask)
        {
            //check the age for the visitor
            if (age < 18)
            {
                return "This visitor is too young";
            }

            //checking if visitor has enough money for the ticket
            if (money < TicketPrice)
            {
                return "Visitor can't afford the ticket";
            }

            if (!hasMask)
            {
                return "Visitor must have a mask to enter";
            }

            if (string.IsNullOrEmpty(fullName))
            {
                return "Visitor must provide their name";
            }

            if (IsVenueFull())
            {
                return "Sorry, there is no more place for a new visitor";
            }

            var visitor = new Visitor()
            {
                FullName = fullName,
                HasMask = hasMask,
                Age = age,
                TicketMoney = money,
                SeatNumber = Visitors.Count + 1
            };

            Visitors.Add(visitor);

            return "Success, visitor was added";
        }

        private bool IsVenueFull()
        {
            return Seats == Visitors.Count;
        }
    }
}
