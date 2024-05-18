using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrarySystem
{
    public class BookRepository : IBookRepository
    {
        //SRP (Single Responsibility Principle)
        //BookRepository class only handles book storage.

        //OCP (Open/Closed Principle)
        //BookRepository can be extended (e.g., with a database implementation) without modifying existing code.

        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            books.RemoveAll(b => b.ISBN == isbn);
        }

        public Book FindBookByISBN(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }
    }

}
