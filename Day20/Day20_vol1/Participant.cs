namespace Day20_vol1
{
    public class Participant
    {
        public int Id;
        public string Name;
        public string Surname;
        public string TeamName;
        public bool Attended;
        public int Age;

        public Participant(int id, string name, string surname, string teamName, bool attended, int age)
        {
            Id = id;
            Name = name;
            Surname = surname;
            TeamName = teamName;
            Attended = attended;
            Age = age;
        }
    }
}