using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_properties
{
    class House
    {
        //field        
        private bool isSomebodyLivingHere;

        //we would like to know, when a field is changing value (set)
        //or a field is being read/used (get)
        //for this case we are using properties

        //fields -> private (starting with a lower case)
        //properties -> public (starting with an upper case)

        //full property with modifications
        private string name;
        public string Name
        {
            get // getter, read/use value
            {
                Console.WriteLine("Name is being read, sending email..");
                //....
                return name;
            }
            set // setter, change/assign value. special keyword: "value"
            {
                Console.WriteLine($"Name is being set to {value}");
                name = value.ToUpper(); //value - anything the user assigned/changed
            }
        }

        //full property with modifications
        private int floors;
        public int Floors
        {
            get { return floors; }
            set 
            {
                if (value > 0)
                {
                    floors = value;  
                }
                else
                {
                    floors = 1;
                }
            }
        }

        //default full property, snippet: propfull
        private string address;
        public string Address
        {
            get 
            { 
                return address; 
            }
            set 
            { 
                address = value; 
            }
        }

        //automatic property
        public int Rent { get; set; }

        //read-only property
        private string ownersName;
        public string OwnersName
        {
            get { return ownersName; }
        }
        //automatic read-only property
        public string OwnersSurname { get; }

        //automatic public-read and private-set property
        public string Nickname { get; private set; }

        public House(string name, string surname)
        {
            ownersName = name;
            OwnersSurname = surname;
        }

        //write only property
        private int electricityAmount;
        public int ElectricityAmount
        {
            set { electricityAmount = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("House info...");
            Console.WriteLine(".....");
            Console.WriteLine($"Electriticy: {electricityAmount} kwh");
        }

    }
}
