using System.Data.Entity;
using BookStore.BusinessObjects;

namespace BookStore.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; } 
    }
}