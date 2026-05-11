using LinkedOut.Api.Data;
using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LinkedOut.Api;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Skill> Skills => Set<Skill>();

    public DbSet<Company> Companies => Set<Company>();

    public DbSet<Requirement> Requirements => Set<Requirement>();

    public DbSet<RequirementSkill> RequirementSkills => Set<RequirementSkill>();

    public DbSet<Profile> Profiles => Set<Profile>();

    public DbSet<ProfileSkill> ProfileSkills => Set<ProfileSkill>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // ищем все IEntityTypeConfiguration в текущей сборке
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Seed();
    }
}
