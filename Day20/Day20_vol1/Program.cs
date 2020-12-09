using System;
using System.Collections.Generic;

namespace Day20_vol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournament tournament = new Tournament();
            tournament.Name = "Running like hell";
            tournament.Participants.Add(new Participant(1, "John", "Blue", "Rockets", true, 15));
            tournament.Participants.Add(new Participant(2, "John", "Blue", "Rockets", false, 10));
            tournament.Participants.Add(new Participant(3, "John", "Blue", "Rockets", true, 25));
            tournament.Participants.Add(new Participant(4, "John", "Blue", "Badboyz", false, 35));
            tournament.Participants.Add(new Participant(5, "John", "Blue", "Badboyz", true, 17));
            tournament.Participants.Add(new Participant(6, "John", "Blue", "Badboyz", false, 27));
            tournament.Participants.Add(new Participant(7, "John", "Blue", "Badboyz", true, 9));

            //let's get all the participants, who attended the tournament
            var attendedParticipants = tournament.GetAttendedParticipants();
            Console.WriteLine($"In the tournament {attendedParticipants.Count} showed up!");

            ////do this
            //tournament.GetAttendedParticipants();
            ////DON'T DO THIS
            //Tournament.GetAttendedParticipants();
        }
    }
}
