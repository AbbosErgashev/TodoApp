using Microsoft.EntityFrameworkCore;
using TodoListApp.Models;

namespace TodoListApp.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base (options)
    { }

    public DbSet<Note> Notes { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }
}