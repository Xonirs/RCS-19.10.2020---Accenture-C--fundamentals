using System;
using System.Collections.Generic;
using System.Text;

namespace Day25_ant
{
    //BossAnt class is derived from base class Ant.
    //BossAnt has public properties - LeadershipExperience, AntArmySize, and a 
    //public method void BossSound(), which prints “This is a secret boss ant sound: SQIIIIIIIQUUUU!”.
    class BossAnt : Ant
    {
        public int AntArmySize { get; set; }
        public int LeadershipExperience { get; set; }

        public void BossSound()
        {
            Console.WriteLine("This is a secret boss ant sound: SQIIIIIIIQUUUU!");
        }
    }
}
