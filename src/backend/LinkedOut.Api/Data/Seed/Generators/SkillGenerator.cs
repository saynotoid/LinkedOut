using LinkedOut.Api.Entities;
using LinkedOut.Api.Data.Seed.DataStores;

namespace LinkedOut.Api.Data.Seed.Generators;

public static class SkillGenerator
{
    public static List<Skill> Generate()
    {
        return StaticDataStore.Skills.Select((name, index) => new Skill
        {
            // Генерируем стабильный ID на основе индекса
            Id = new Guid($"00000000-0000-0000-0000-{index + 1:D12}"),
            Name = name,
            Category = index < 4 ? "Backend" : index < 6 ? "Frontend" : "Infrastructure"
        }).ToList();
    }
}
