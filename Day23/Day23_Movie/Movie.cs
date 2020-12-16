using System;
using System.Collections.Generic;
using System.Text;

namespace Day23_Movie
{
    /*
     Create a class Movie. Create 4 public properties. 
    Full property (with private field) - string Name, 
    automatic property – int Year, 
    read-only property – int Price, 
    write-only property – Director. 
    Create a constructor which will allow to set all the values 
     */
    class Movie
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year { get; set; }

        public int Price { get; }

        private string director;
        public string Director
        {
            set { director = value; }
        }

        public Movie(string _name, int _year, int _price, string _director)
        {
            name = _name;
            Year = _year;
            Price = _price;
            director = _director;
        }
    }
}
