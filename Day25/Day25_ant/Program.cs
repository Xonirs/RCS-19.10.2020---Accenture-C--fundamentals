using System;

namespace Day25_ant
{
    //In Program.Main create Ant and fill all the properties values, print them and use the method WorkerSound(). 
    //Create BossAnt and fill all the properties (also the ones inherited from Ant), print them and 
    //use the method WorkerSound() and BossSound().
    class Program
    {
        static void Main(string[] args)
        {
            Ant ant = new Ant();
            ant.Name = "Tiny";
            ant.Size = 5;
            ant.WorkerSound();

            BossAnt boss = new BossAnt();
            boss.Name = "Supreme Leader Boss Manager Ant";
            boss.Size = 5;
            boss.WorkerSound();
            boss.AntArmySize = 3000;
            boss.LeadershipExperience = 9;
            boss.BossSound();
        }
    }
}
