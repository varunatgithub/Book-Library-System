namespace BookLibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();
            ILibrary library = new Library(bookRepository);

            library.AddNewBook("The Catcher in the Rye", "J.D. Salinger", "9780316769488");
            library.AddNewBook("To Kill a Mockingbird", "Harper Lee", "9780060935467");

            Console.WriteLine("All books in the library:");
            library.DisplayAllBooks();

            library.RemoveBook("9780316769488");

            Console.WriteLine("\nAfter removing 'The Catcher in the Rye':");
            library.DisplayAllBooks();
        }
    }

}
