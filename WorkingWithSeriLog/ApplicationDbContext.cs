using Microsoft.EntityFrameworkCore;
using WorkingWithSeriLog.Models;

namespace WorkingWithSeriLog
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                    new Person { Id = 1, Name = "Tom", Surname = "Showyer", Age = 37 },
                    new Person { Id = 2, Name = "Bob", Surname = "Marley", Age = 41 },
                    new Person { Id = 3, Name = "Sam", Surname = "Smith", Age = 24 }
            );
        }
    }
}