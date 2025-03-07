using LibraryCatalog.Books;

namespace LibraryCatalog
{
    public class MyApp
    {
        public void SomeOperation()
        {
            var catalog = new BookCollection();
            catalog.books.Add(new Book("1984", "George Orwell", "Fiction"));
            catalog.books.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Fiction"));
            catalog.books.Add(new Book("Sapiens", "Yuval Noah Harari", "Non-Fiction"));

            // Iterate over all books
            var iteratorAll = catalog.GetIteratorAll();
            Console.WriteLine("All Books:");
            while (iteratorAll.HasMore())
            {
                Console.WriteLine(iteratorAll.GetNext());
            }

            Console.WriteLine("\n***********************************************");

            // Iterate over books in the "Fiction" genre
            var iteratorByGenre = catalog.GetIteratorByGenre("Fiction");
            Console.WriteLine("Fiction Books:");
            while (iteratorByGenre.HasMore())
            {
                Console.WriteLine(iteratorByGenre.GetNext());
            }
            
            Console.WriteLine("\n***********************************************");

            // Iterate over books by "George Orwell"
            var iteratorByAuthor = catalog.GetIteratorByAuthor("George Orwell");
            Console.WriteLine("Books by George Orwell:");
            while (iteratorByAuthor.HasMore())
            {
                Console.WriteLine(iteratorByAuthor.GetNext());
            }
        }
    }
}
