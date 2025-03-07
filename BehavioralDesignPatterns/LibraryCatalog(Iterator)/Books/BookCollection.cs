using LibraryCatalog.Iterators;

namespace LibraryCatalog.Books
{
    public class BookCollection : IBookCollection
    {
        public List<Book> books { get; set; } = new List<Book>();

        public IBookIterator GetIteratorAll()
        {
            return new IteratorAll(this);
        }

        public IBookIterator GetIteratorByAuthor(string author)
        {
            return new IteratorByAuthor(this, author);
        }

        public IBookIterator GetIteratorByGenre(string genre)
        {
            return new IteratorByGenre(this, genre);
        }
    }
}
