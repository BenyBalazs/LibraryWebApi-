using LibraryWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApi.Repositories
{
    public class LibraryContext : DbContext
    {

        public DbSet<Reader> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\mssqllocaldb;Database=LibrarayDb;Integrated Security=True;");
        }
    }
}
