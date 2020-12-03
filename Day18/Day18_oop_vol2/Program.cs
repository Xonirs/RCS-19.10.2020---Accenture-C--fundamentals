using System;

namespace Day18_oop_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var concert = new Concert();
            //concert.Artist = "The Beatles";
            //concert.City = "Stockholm";
            //concert.Name = "BEATLES RETURN";
            ////concert.XXX = .....
            ////..........

            var concertTest = new Concert()
            { 
                Artist = "The Beatles",
                TicketPrice = 13
            };
            concertTest.PrintConcertInfo();

            var concert = new Concert()
            {
                Artist = "The Beatles",
                City = "Stockholm",
                ExpectedDuration = 200,
                Name = "BEATLES RETURN",
                Seats = 10000,
                TicketPrice = 5000,
                Venue = "H9"
            };

            concert.PrintConcertInfo();

            //WE DON"T WANT FOR THIS TO HAPPEN BY ACCIDENT
            //SO USE private KEYWORD FOR VISITORS
            //concert.Visitors.Clear();

            var newConcert = new Concert()
            {
                Artist = "Brainstorm",
                City = "Riga",
                ExpectedDuration = 200,
                Name = "PV FOREVER",
                Seats = 9,
                TicketPrice = 30,
                Venue = "Arena Riga",
                Date = new DateTime(2020, 12, 3)
            };
            
            concert.PrintConcertInfo();

            //let's add visitors to concert
            newConcert.AddVisitor("Maria Tabgenom", 21, 30.00, true);

            string message = newConcert.AddVisitor("Tom Jokersfield", 18, 30.00, true);
            Console.WriteLine(message);

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(newConcert.AddVisitor("Tom Jokersfield", 18, 30.00, true)); 
            }

            //testing all the validations
            Console.WriteLine(newConcert.AddVisitor("Ann Baker", 17, 30.00, true));
            Console.WriteLine(newConcert.AddVisitor("Jody Jokersfield", 18, 12.00, true));
            Console.WriteLine(newConcert.AddVisitor("Bob Jokersfield", 18, 30.00, false));
            Console.WriteLine(newConcert.AddVisitor("", 18, 30.00, true));

            //testing if Venue is full
            Console.WriteLine(newConcert.AddVisitor("Tom Jokersfield", 18, 30.00, true));

            newConcert.PrintConcertInfo();
        }
    }
}
