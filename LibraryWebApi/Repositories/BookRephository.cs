using LibraryWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApi.Repositories
{
    public class BookRephository
    {
        public static IList<Book> GetAllBooks()
        {
            using (var Database = new LibraryContext())
            {
                return Database.Books.ToList();
            }
        }
        public static Book GetBookById(long Id)
        {
            using (var Database = new LibraryContext())
            {
                return Database.Books.Where(x => x.Id == Id).FirstOrDefault();
            }
        }

        public static void AddBook(Book book)
        {
            using (var Database = new LibraryContext())
            {
                Database.Books.Add(book);
                Database.SaveChanges();
            }
        }
        public static void UpdateBook(Book book)
        {
            using (var Database = new LibraryContext())
            {
                Database.Books.Update(book);
                Database.SaveChanges();
            }
        }
        public static void DeleteBook(Book book)
        {
            using (var Database = new LibraryContext())
            {
                Database.Books.Remove(book);
                Database.SaveChanges();
            }
        }
    }
}
