namespace LibrarySystem
{
    using System;
    public class Book : IBorrowable
    {
        protected string title;
        protected string author;
        public bool isBorrowed;
        private DateTime borrowTime;
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
                    borrowTime = DateTime.Now;
                    Console.WriteLine($"{reader.name} have borrowed '{this.title}' by {this.author}.");
                    Console.WriteLine($"Borrowing time: {borrowTime}\n");
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
                Console.WriteLine($"{reader.name}'s Error: The book '{this.title}' is not found in this library");
                return false;
            }
        }


        // Method to return the book
        public void Return(Reader reader)
        {
            if (this.isBorrowed)
            {
                this.isBorrowed = false;

                DateTime now = DateTime.Now;
                TimeSpan timeSpan = now - borrowTime;

                Console.WriteLine($"{reader.name} have returned '{this.title}'.");
                Console.WriteLine($"Returning time: {now}");

                if (timeSpan.TotalDays > 7)
                {
                    Console.WriteLine($"Total borrowed duration: {timeSpan.Days} days, {timeSpan.Hours} hours, {timeSpan.Minutes} minutes. You have exceeded the 7-day borrowing limit and you will receive a fine.\n");
                }
                else
                {
                    Console.WriteLine($"Total borrowed duration: {timeSpan.Days} days, {timeSpan.Hours} hours, {timeSpan.Minutes} minutes. Thank you for returning the book on time!\n");
                }
            }
            else
            {
                Console.WriteLine($"Sorry {reader.name}, '{this.title}' was not borrowed.");
            }
        }

        //  Method to get book details
        public virtual string Str()
        {
            return $"Title:{this.title}, Author:{this.author}";
        }
    }
}