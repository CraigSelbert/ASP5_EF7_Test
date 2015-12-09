using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace ASPNET5_EF7_Test
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(x => x.Id).HasColumnName("UserId");
        }
    }
}