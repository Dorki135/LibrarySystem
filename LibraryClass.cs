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
            Console.WriteLine($"Added '{book.Str()}' to the library.");
        }
        // Method to register a new reader
        public void RegisterReader(Reader reader)
        {
            readers.Add(reader);
            Console.WriteLine($"Registered new reader: {reader.name}");
        }
    }
}