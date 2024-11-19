using EagerLoadinglazyLoading.Models;
using Microsoft.EntityFrameworkCore;

namespace EagerLoadinglazyLoading.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        public DbSet<Author>Authors { get; set; }   
        public DbSet<Book>Books { get; set; }
    }
}
