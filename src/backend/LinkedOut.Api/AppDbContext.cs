using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Api
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Skill> Skills => Set<Skill>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Skill>();

            entity.ToTable("skills");

            entity.Property(s=>s.Id).HasColumnName("id");
            entity.Property(s => s.Name).HasColumnName("name");
            entity.Property(s => s.Category).HasColumnName("category");
            entity.Property(s => s.CreatedAt).HasColumnName("created_at").ValueGeneratedOnAdd();
        }
    }
}
