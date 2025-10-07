namespace LibrarySystem
{
    public class DigitalBook : Book
    {
        protected int fileSizeMB;

        public DigitalBook(string title, string author, int fileSizeMB)
            : base(title, author)
        {
            this.fileSizeMB = fileSizeMB;
        }

        // Override method to get digital book details
        public override string Str()
        {
            return $"title: {title}, author: {author}, file size: {this.fileSizeMB} MB";
        }
    }
}
