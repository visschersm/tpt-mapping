using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MTech.TPTMapping
{
    public class AnimalContext : DbContext
    {
        public DbSet<Cow> Cows {get;set;}
        public DbSet<Horse> Horses {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("AnimalContext");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().ToTable("Animals");
            modelBuilder.Entity<Cow>().ToTable("Cow");
            modelBuilder.Entity<Horse>().ToTable("Horse");
        }
    }
}