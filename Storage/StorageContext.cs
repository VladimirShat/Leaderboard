using Microsoft.EntityFrameworkCore;

namespace Storage
{
    public class StorageContext : DbContext
    {
        public DbSet<Player> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasIndex(p => p.Name).IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=wt;Database=postgres;"; //place for secret connection string
            optionsBuilder.UseNpgsql(connectionString)
                .UseLazyLoadingProxies();
        }
    }
}