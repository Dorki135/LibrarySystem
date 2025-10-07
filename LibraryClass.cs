namespace LibrarySystem
{
    using System;
    using System.Collections.Generic;
    public class Library
    {
        public List<Book> books;
        public List<Reader> readers;
        public Library()
        {
            books = new List<Book>();
            readers = new List<Reader>();
        }
        // Method to add a book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added '{book.Str()}' to the library.\n");
        }
        // Method to register a new reader
        public void RegisterReader(Reader reader)
        {
            readers.Add(reader);
            Console.WriteLine($"Registered new reader: {reader.name}\n");
        }
        //method to serarch book by title
        public void SearchBookByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Str().Contains(title))
                {
                    Console.WriteLine($"Found book: {book.Str()}");
                    if (book.isBorrowed)
                    {
                        Console.WriteLine($"Status: Borrowed\n");
                    }
                    else
                    {
                        Console.WriteLine("Status: Available\n");
                    }
                    return;
                }
            }
            Console.WriteLine($"Book with title '{title}' not found.\n");
        }
        //method to search reader by name
        public void SearchReaderByName(string name)
        {
            foreach (Reader reader in readers)
            {
                if (reader.name == name)
                {
                    Console.WriteLine($"Found reader: {reader.name}");
                    reader.listBooks();
                    return;
                }
            }
            Console.WriteLine($"Reader with name '{name}' not found.\n");
        }
        //methid to list all the available books in the library
        public void ListAvailableBooks()
        {
            Console.WriteLine("Available books in the library:");
            foreach (Book book in books)
            {
                if (!book.isBorrowed)
                {
                    Console.WriteLine(book.Str());
                }
            }
            Console.WriteLine("");
        }
    }
}