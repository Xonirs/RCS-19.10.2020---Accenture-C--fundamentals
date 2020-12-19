using System;

namespace Day24_Library
{
    //Create an application for Library. Library can contain multiple Books. Each book has an Author.
    // At Library you can find books after book name or author.Create a console application and create library
    //with multiple books and their authors.Use book search both by name and author.
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Author author1 = new Author("Bob", "Tree", "Dark candle");            
            Author author2 = new Author("Maria", "Kerlfield", "Rainbow");            
            Author author3 = new Author("Richie", "Couch", "Big fish");
            Book book1 = new Book("ISBN-ZXCV","Adventures of little fish", author1);
            Book book2 = new Book("ISBN-QWER","Pride and food", author1);
            Book book3 = new Book("ISBN-ASDF","Harry Potter and the covid19", author1);
            Book book4 = new Book("ISBN-RTYU","Life after covid", author2);
            Book book5 = new Book("ISBN-BNMJ","Mockingtiger", author2);
            Book book6 = new Book("ISBN-TGBV","The big door", author3);
            library.AddBook(book1);
            library.AddBook(book2);
            Console.WriteLine(library.AddBook(book3));
            Console.WriteLine(library.AddBook(book4));
            Console.WriteLine(library.AddBook(book5));
            Console.WriteLine(library.AddBook(book6));

            var bookList1 = library.FindByBookTitle("oo");
            Console.WriteLine("Book search by title with 'oo'");
            foreach (var book in bookList1)
            {
                Console.WriteLine($"Book title: {book.Title}");
            }
            Console.WriteLine();

            var bookList2 = library.FindByBookAuthor("bob");
            Console.WriteLine("Book search by author with 'bob'");
            foreach (var book in bookList2)
            {
                Console.WriteLine($"Book title: {book.Title}");
            }
            Console.WriteLine();

        }
    }
}
