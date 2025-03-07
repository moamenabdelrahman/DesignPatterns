using LibraryCatalog.Books;

namespace LibraryCatalog.Iterators
{
    public class IteratorAll : BaseIterator
    {
        public IteratorAll(IBookCollection collection) : base(collection)
        {
        }

        public override Book GetNext()
        {
            var book = _collection.books[_currPos];
            _currPos++;
            return book;
        }

        public override bool HasMore()
        {
            return _currPos < _collection.books.Count;
        }

        public override void Reset()
        {
            _currPos = 0;
        }
    }
}
