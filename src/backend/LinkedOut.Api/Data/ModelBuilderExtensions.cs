using LinkedOut.Api.Data.Seed.Generators;
using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Api.Data;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Skill>().HasData(SkillGenerator.Generate());

        var (companies, requirements) = CompanyGenerator.Generate();
        modelBuilder.Entity<Company>().HasData(companies);
        modelBuilder.Entity<Requirement>().HasData(requirements);
    }
}
