using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Api
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Skill> Skills => Set<Skill>();

        public DbSet<Company> Companies => Set<Company>();

        public DbSet<Requirement> Requirements => Set<Requirement>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Навыки
            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("skills");
                entity.Property(s => s.Id).HasColumnName("id");
                entity.Property(s => s.Name).HasColumnName("name");
                entity.Property(s => s.Category).HasColumnName("category");
                entity.Property(s => s.CreatedAt).HasColumnName("created_at").ValueGeneratedOnAdd();
            });

            // Компании
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("companies");
                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Name).HasColumnName("name");
                entity.Property(c => c.Location).HasColumnName("location");
            });

            // Требования
            modelBuilder.Entity<Requirement>(entity =>
            {
                entity.ToTable("requirements");
                entity.Property(r => r.Id).HasColumnName("id");
                entity.Property(r => r.CompanyId).HasColumnName("company_id");
                entity.Property(r => r.Title).HasColumnName("title");
            });
        }
    }
}
