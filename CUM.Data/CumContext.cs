using System.Data.Common;
using CUM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CUM.Data
{
    public class CumContext : DbContext 
    {
        public DbSet<User> User { get; set; }
        public CumContext(DbContextOptions<CumContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("user")
                    .HasKey(u => u.UserId);
                e.Property(p => p.UserId)
                    .ValueGeneratedOnAdd();
            });
        }
    }
}   