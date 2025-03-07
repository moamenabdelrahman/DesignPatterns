using LibraryCatalog.Iterators;

namespace LibraryCatalog.Books
{
    public interface IBookCollection
    {
        public List<Book> books { get; set; }

        public IBookIterator GetIteratorAll();

        public IBookIterator GetIteratorByGenre(string genre);

        public IBookIterator GetIteratorByAuthor(string author);
    }
}
