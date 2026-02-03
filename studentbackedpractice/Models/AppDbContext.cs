using Microsoft.EntityFrameworkCore;
using studentbackedpractice.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
    {
        
    }
    public DbSet<CourseRegistration>Registrations{get;set;}
}