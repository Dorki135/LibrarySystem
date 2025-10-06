namespace LibrarySystem
{
    public class Reader
    {
        public string name;
        private List<Book> borrowedBooks;
        public Reader(string name)
        {
            this.name = name;
            this.borrowedBooks = new List<Book>();
        }
        // Method for the reader to borrow a book
        public void BorrowBook(Book book, Library library)
        {
            if (book.Borrow(library, this))
            {
                borrowedBooks.Add(book);
            }
        }
        // Method for the reader to return a book
        public void ReturnBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                book.Return(this);
                borrowedBooks.Remove(book);
            }
            else
            {
                Console.WriteLine($"You did not borrow '{book.Str()}'.");
            }
        }
        // Method to list all borrowed books
        public void listBooks()
        {
            Console.WriteLine($"{name} has borrowed the following books:");
            foreach (Book book in borrowedBooks)
            {
                Console.WriteLine(book.Str());
            }
        }
    }
}