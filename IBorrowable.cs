namespace LibrarySystem
{
    public interface IBorrowable
    {
        bool Borrow(Library library, Reader reader);
        void Return(Reader reader);
    }
}