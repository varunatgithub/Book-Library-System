namespace BookLibrarySystem
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void RemoveBook(string isbn);
        Book FindBookByISBN(string isbn);
        List<Book> GetAllBooks();
    }

}
