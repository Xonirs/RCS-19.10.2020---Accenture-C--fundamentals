using System;
using System.Collections.Generic;
using System.Text;

namespace Day23_properties
{
    enum TreeType
    {
        Silver,
        Traditional
    }
    class ChristmasTree
    {
        //fields and properties
        //fields - should be private
        //properties - should be public

        //field
        private string treeDNA;

        //full property
        private TreeType type;
        public TreeType Type
        {
            get //when reading/using a value
            {
                return type;
            }
            set //when changing/assigning a value
            {
                type = value;
            }
        }

        //auto property
        public int Height { get; set; }

        //full property
        private int branchWidth;
        public int BranchWidth
        {
            get 
            { 
                return branchWidth; 
            }
            set 
            {
                if (value < 10 || value > Height)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect width value, setting automatic one");
                    Console.ResetColor();
                    branchWidth = Height / 2;
                }
                else
                {
                    branchWidth = value;
                }                
            }
        }

        //read-only auto property
        public string Name { get; }

        //write-only property
        private string owner;
        public string Owner
        {
            set { owner = value; }
        }

        public List<string> OldPresents { get; set; } = new List<string>();

        private List<string> presents = new List<string>();
        private string lastPresent;
        public string LastPresent
        {
            get { return lastPresent; }
            set 
            {
                presents.Add(value);
                lastPresent = value; 
            }
        }

        public void PrintAllPresents()
        {
            foreach (var item in presents)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        public int Width { get; set; }

        /*
         *  Height (cm) Branch width (cm) Room
            50 <= x < 100 100 <= y < 150 Living room nr.1
            100 <= x < 150 150 <= y < 200 Living room nr.2
            150 <= x <= 300 200 <= y <= 300 Fireplace hall
         */
        public void PrintLocation()
        {
            if (Type == TreeType.Silver || (150 <= Height && Height < 300 && 200 <= Width && Width < 300))
            {
                Console.WriteLine("Placing in the fireplace hall");
            }
            else if (50 <= Height && Height < 100 && 100 <= Width && Width < 150)
            {
                Console.WriteLine("Placing in the living room nr.1");
            }
            else if (100 <= Height && Height < 150 && 150 <= Width && Width < 200)
            {
                Console.WriteLine("Placing in the living room nr.2");
            }
        }
    }
}
