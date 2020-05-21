using LibraryWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApi.Repositories
{
    public static class ReaderRephository
    {
        public static IList<Reader> GetAllUsers()
        {
            using (var Database = new LibraryContext())
            {
                return Database.Users.ToList();
            }
        }
        public static Reader GetUserById(long Id)
        {
            using (var Database = new LibraryContext())
            {
                return Database.Users.Where(x => x.Id == Id).FirstOrDefault();
            }
        }

        public static void AddUser(Reader user)
        {
            using (var Database = new LibraryContext())
            {
                Database.Users.Add(user);
                Database.SaveChanges();
            }
        }
        public static void UpdateUser(Reader user)
        {
            using(var Database = new LibraryContext())
            {
                    Database.Users.Update(user);
                    Database.SaveChanges();
            }
        }
        public static void DeleteUser(Reader user)
        {
            using(var Database = new LibraryContext())
            {
                Database.Users.Remove(user);
                Database.SaveChanges();
            }
        }
    }

}
