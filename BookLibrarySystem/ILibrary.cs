namespace BookLibrarySystem
{
    public interface ILibrary
    {
        //ISP (Interface Segregation Principle):
        //Separate interfaces for book repository(IBookRepository) and library operations(ILibrary) ensure that clients are not forced to depend on methods they do not use.

        void DisplayAllBooks();
        void AddNewBook(string title, string author, string isbn);
        void RemoveBook(string isbn);
    }

}
