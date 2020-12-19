using System;
using System.Collections.Generic;
using System.Text;

namespace Day24_Library
{
    class Book
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string ISBN { get; set; }
        public Author Author { get; set; }

        public Book()
        {

        }

        public Book(string isbn, string title, Author author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            
        }
    }
}
