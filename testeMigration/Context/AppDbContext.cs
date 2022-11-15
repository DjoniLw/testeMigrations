using Microsoft.EntityFrameworkCore;
using testeMigration.Models;

namespace testeMigration.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Pessoa> Pessoas { get; set; }
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Pessoa>()
            .Property(c => c.Name)
            .HasMaxLength(100)
            .IsRequired();        
    }
}
