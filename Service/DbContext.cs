using BusShuttle.Models;

namespace BusShuttle.Service;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    //add more things here to add to the database then run
    //dotnet ef migrations add (insert name here migration)
    //dotnet ef database update
    public DbSet<User> Users { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=mydatabase.db");
    }
}