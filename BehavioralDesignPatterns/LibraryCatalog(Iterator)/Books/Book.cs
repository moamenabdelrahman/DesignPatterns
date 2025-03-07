namespace LibraryCatalog.Books
{
    public class Book
    {
        public string title { get; set; }

        public string author { get; set; }

        public string genre { get; set; }

        public Book(string title, string author, string genre)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
        }

        public override string ToString()
        {
            return $"Title: {this.title} | Author: {this.author} | Genre: {this.genre}";
        }
    }
}
