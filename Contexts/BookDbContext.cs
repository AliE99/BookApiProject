using BookApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApiProject.Contexts
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Reviewer> Reviewers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }
        public virtual DbSet<BookCategory> BookCategories { get; set; }
    }
}