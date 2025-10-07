namespace LibrarySystem
{
    using System;
    public class Book
    {
        protected string title;
        protected string author;
        public bool isBorrowed;
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
                    Console.WriteLine($"{reader.name} have borrowed '{this.title}' by {this.author}.\n");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Sorry {reader.name}, '{this.title}' is already borrowed.\n");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"{reader.name}'s Error: The book '{this.title}' is not found in this library\n");
                return false;
            }
        }
        // Method to return the book
        public void Return(Reader reader)
        {
            if (this.isBorrowed)
            {
                this.isBorrowed = false;
                Console.WriteLine($"{reader.name} have returned '{this.title}'.\n");
            }
            else
            {
                Console.WriteLine($"'Sorry {reader.name},{this.title}' was not borrowed.\n");
            }
        }

        //  Method to get book details
        public virtual string Str()
        {
            return $"Title:{this.title}, Author:{this.author}";
        }
    }
    // Reader class representing a library member
}