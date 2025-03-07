using LibraryCatalog.Books;

namespace LibraryCatalog.Iterators
{
    public abstract class BaseIterator: IBookIterator
    {
        protected IBookCollection _collection { get; set; }

        protected int _currPos { get; set; }

        protected BaseIterator(IBookCollection collection)
        {
            _collection = collection;
        }

        public abstract Book GetNext();
        public abstract bool HasMore();
        public abstract void Reset();
    }
}
