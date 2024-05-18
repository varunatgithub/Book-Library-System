namespace BookLibrarySystem
{
    public class Library : ILibrary
    {
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
