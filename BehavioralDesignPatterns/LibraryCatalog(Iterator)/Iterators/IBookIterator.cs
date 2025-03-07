using LibraryCatalog.Books;

namespace LibraryCatalog.Iterators
{
    public interface IBookIterator
    {
        public Book GetNext();

        public bool HasMore();

        public void Reset();
    }
}
