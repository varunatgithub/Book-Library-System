namespace BookLibrarySystem
{
    public interface ILibrary
    {
        void DisplayAllBooks();
        void AddNewBook(string title, string author, string isbn);
        void RemoveBook(string isbn);
    }

}
