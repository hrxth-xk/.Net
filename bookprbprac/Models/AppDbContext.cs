using Microsoft.EntityFrameworkCore;
using bookprbprac.Models;

namespace bookprbprac.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Book>Books{get;set;}
    }

}