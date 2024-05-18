namespace BookLibrarySystem
{
    public class Book
    {
        //SRP (Single Responsibility Principle)
        //Book class only handles book details.
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }

}
