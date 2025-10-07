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
            if (borrowedBooks.Count >= 3)
            {
                Console.WriteLine($"{name} cannot borrow more than 3 books at a time.\n");
                return;
            }
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
                Console.WriteLine($"{name} did not borrow '{book.Str()}'./n");
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
            System.Console.WriteLine("");
        }
    }
}