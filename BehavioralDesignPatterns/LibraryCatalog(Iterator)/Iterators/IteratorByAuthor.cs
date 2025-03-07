using LibraryCatalog.Books;

namespace LibraryCatalog.Iterators
{
    public class IteratorByAuthor: BaseIterator
    {
        private string _author { get; set; }

        public IteratorByAuthor(IBookCollection collection, string author): base(collection)
        {
            _author = author;
        }

        public override Book GetNext()
        {
            var book = _collection.books[_currPos];
            _currPos++;
            while (_currPos < _collection.books.Count && _collection.books[_currPos].author != _author) _currPos++;
            return book;
        }

        public override bool HasMore()
        {
            return _currPos < _collection.books.Count;
        }

        public override void Reset()
        {
            _currPos = 0;
            while (_currPos < _collection.books.Count && _collection.books[_currPos].author != _author) _currPos++;
        }
    }
}
