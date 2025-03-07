using LibraryCatalog.Books;

namespace LibraryCatalog.Iterators
{
    public class IteratorByGenre : BaseIterator
    {
        private string _genre { get; set; }

        public IteratorByGenre(IBookCollection collection, string genre): base(collection)
        {
            _genre = genre;
        }

        public override Book GetNext()
        {
            var book = _collection.books[_currPos];
            _currPos++;
            while (_currPos < _collection.books.Count && _collection.books[_currPos].genre != _genre) _currPos++;
            return book;
        }

        public override bool HasMore()
        {
            return _currPos < _collection.books.Count;
        }

        public override void Reset()
        {
            _currPos = 0;
            while (_currPos < _collection.books.Count && _collection.books[_currPos].genre != _genre) _currPos++;
        }
    }
}
