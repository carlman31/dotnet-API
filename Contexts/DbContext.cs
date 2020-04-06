using Microsoft.EntityFrameworkCore;

namespace CarlosCuellarApi.Repositories
{
    public class SampleContext : DbContext
    {
        public DbSet<Models.Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(@"Data Source=sample.db3;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Student>().ToTable("Student");
        }
    }
}
