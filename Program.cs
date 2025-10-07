namespace LibrarySystem
{
    using System;
    using System.Collections.Generic;
    public static class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();
            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
            DigitalBook ebook1 = new DigitalBook("Digital Fortress", "Dan Brown", 5);
            DigitalBook ebook2 = new DigitalBook("The Martian", "Andy Weir", 3);
            Reader reader1 = new Reader("Alice");
            Reader reader2 = new Reader("Bob");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(ebook1);
            library.AddBook(ebook2);
            library.RegisterReader(reader1);
            library.RegisterReader(reader2);
            Console.WriteLine("Library setup complete.\n");
            reader1.BorrowBook(book1, library);
            reader2.BorrowBook(book2, library);
            reader2.BorrowBook(ebook1, library);
            reader1.listBooks();
            reader2.listBooks();
            library.SearchBookByTitle("1984");
            library.SearchBookByTitle("Harry Potter");
            library.SearchReaderByName("Alice");
            reader2.ReturnBook(book2);
            reader1.ReturnBook(book1);
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            library.RegisterReader(new Reader("Charlie"));
            library.books.ForEach(b => b.Str());
            Console.WriteLine("Library operations complete.");

        }

    }
}