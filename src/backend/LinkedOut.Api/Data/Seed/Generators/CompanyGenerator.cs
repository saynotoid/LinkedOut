using LinkedOut.Api.Entities;
using LinkedOut.Api.Data.Seed.DataStores;

namespace LinkedOut.Api.Data.Seed.Generators;

public static class CompanyGenerator
{
    public static (List<Company> Companies, List<Requirement> Requirements) Generate()
    {
        var companies = new List<Company>();
        var requirements = new List<Requirement>();

        for (int i = 0; i < StaticDataStore.CompanyNames.Length; i++)
        {
            var compId = Guid.Parse($"11111111-1111-1111-1111-{i + 1:D12}");

            companies.Add(new Company
            {
                Id = compId,
                Name = StaticDataStore.CompanyNames[i],
                Location = "Ukraine"
            });

            // Генерируем по 2 требования на компанию
            for (int j = 1; j <= 2; j++)
            {
                requirements.Add(new Requirement
                {
                    Id = Guid.Parse($"22222222-2222-2222-2222-{(i * 2) + j:D12}"),
                    CompanyId = compId,
                    Title = j == 1 ? "Fullstack Developer" : "Backend Engineer"
                });
            }
        }

        return (companies, requirements);
    }
}
