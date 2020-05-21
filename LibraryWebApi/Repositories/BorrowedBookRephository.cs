using LibraryWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApi.Repositories
{
    public class BorrowedBookRephository
    {
        public static IList<BorrowedBook> GetAllBorrowedBooks()
        {
            using (var Database = new LibraryContext())
            {
                return Database.BorrowedBooks.ToList();
            }
        }
        public static BorrowedBook GetByBorrowedBookId(long Id)
        {
            using (var Database = new LibraryContext())
            {
                return Database.BorrowedBooks.Where(x => x.Id == Id).FirstOrDefault();
            }
        }

        public static void AddNewBorrow(BorrowedBook borrowedBook)
        {
            using (var Database = new LibraryContext())
            {
                Database.BorrowedBooks.Add(borrowedBook);
                Database.SaveChanges();
            }
        }
        public static void UpdateBorrw(BorrowedBook borrowedBook)
        {
            using (var Database = new LibraryContext())
            {
                Database.BorrowedBooks.Update(borrowedBook);
                Database.SaveChanges();
            }
        }
        public static void DeleteBorrow(BorrowedBook borrowedBook)
        {
            using (var Database = new LibraryContext())
            {
                Database.BorrowedBooks.Remove(borrowedBook);
                Database.SaveChanges();
            }
        }
    }
}

