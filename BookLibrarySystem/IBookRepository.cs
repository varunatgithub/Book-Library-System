using System.Runtime.Intrinsics.X86;

namespace BookLibrarySystem
{
    public interface IBookRepository
    {

        //ISP (Interface Segregation Principle):
        //Separate interfaces for book repository(IBookRepository) and library operations(ILibrary) ensure that clients are not forced to depend on methods they do not use.
        
        void AddBook(Book book);
        void RemoveBook(string isbn);
        Book FindBookByISBN(string isbn);
        List<Book> GetAllBooks();
    }

}
