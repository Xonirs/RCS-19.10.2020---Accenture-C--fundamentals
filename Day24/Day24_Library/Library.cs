using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day24_Library
{
    class Library
    {
        public string Name { get; set; }
        private List<Book> books = new List<Book>();

        public List<Book> FindByBookTitle(string title)
        {
            return books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> FindByBookAuthor(string searchValue)
        {
            return books.Where(book => book.Author.Name.Contains(searchValue, StringComparison.OrdinalIgnoreCase) ||
                                    book.Author.Surname.Contains(searchValue, StringComparison.OrdinalIgnoreCase) ||
                                    book.Author.Pseudonym.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public string AddBook(Book book)
        {
            //checking if there is a book to add
            if (book == null)
            {
                return "Book is non-existing!";
            }
            //checking if the title has a value
            if (string.IsNullOrEmpty(book.Title))
            {
                return "Book title can't be empty!";
            }
            //checking if the book as an author
            if (book.Author == null)
            {
                return "Book must have an author!";
            }

            books.Add(book);

            return "A book was successfuly added!";
        }
    }
}
