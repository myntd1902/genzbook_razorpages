using GenZBookRazorPages.Model;
using Microsoft.EntityFrameworkCore;

namespace GenZBookRazorPages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
