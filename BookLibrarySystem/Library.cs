namespace BookLibrarySystem
{
    public class Library : ILibrary
    {
        #region
        //LSP (Liskov Substitution Principle)
        //Library can work with any class that implements IBookRepository.

        //DIP (Dependency Inversion Principle):
        //Library depends on the IBookRepository abstraction, not a concrete implementation, allowing flexibility and easier testing.
        #endregion

        private readonly IBookRepository _bookRepository;

        public Library(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void DisplayAllBooks()
        {
            var books = _bookRepository.GetAllBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            }
        }

        public void AddNewBook(string title, string author, string isbn)
        {
            var book = new Book(title, author, isbn);
            _bookRepository.AddBook(book);
        }

        public void RemoveBook(string isbn)
        {
            _bookRepository.RemoveBook(isbn);
        }
    }

}
