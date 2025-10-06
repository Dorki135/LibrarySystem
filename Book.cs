namespace LibrarySystem
{
    using System;
    public class Book
    {
        private string title;
        private string author;
        private bool isBorrowed;
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isBorrowed = false;
        }
        // Method to borrow the book
        public bool Borrow(Library library, Reader reader)
        {
            if (library.books.Contains(this))
            {
                if (!this.isBorrowed)
                {
                    this.isBorrowed = true;
                    Console.WriteLine($"{reader.name} have borrowed '{this.title}' by {this.author}.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Sorry {reader.name}, '{this.title}' is already borrowed.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"{reader.name}'s Error: The book '{this.title}' is not found in this library.");
                return false;
            }
        }
        // Method to return the book
        public void Return(Reader reader)
        {
            if (this.isBorrowed)
            {
                this.isBorrowed = false;
                Console.WriteLine($"{reader.name} have returned '{this.title}'.");
            }
            else
            {
                Console.WriteLine($"'Sorry {reader.name},{this.title}' was not borrowed.");
            }
        }

        //  Method to get book details
        public string Str()
        {
            return $"Title:{this.title}, Author:{this.author}";
        }
    }
    // Reader class representing a library member
}