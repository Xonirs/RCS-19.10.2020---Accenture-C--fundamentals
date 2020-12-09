using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_vol1
{
    class Tournament
    {
        public string Name;
        public List<Participant> Participants = new List<Participant>();

        public List<Participant> GetAttendedParticipants()
        {
            List<Participant> attendedList = new List<Participant>();

            foreach (Participant p in Participants)
            {
                if (p.Attended)
                {
                    attendedList.Add(p);
                }
            }

            return attendedList;
        }
    }
}
