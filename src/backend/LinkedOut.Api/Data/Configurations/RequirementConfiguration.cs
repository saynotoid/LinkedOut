using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkedOut.Api.Data.Configurations
{
    public class RequirementConfiguration : IEntityTypeConfiguration<Requirement>
    {
        public void Configure(EntityTypeBuilder<Requirement> builder)
        {
            builder.ToTable("requirements");

            builder.Property(s => s.Id)
                .HasColumnName("id");
            builder.Property(s => s.CompanyId)
                .HasColumnName("company_id");
            builder.Property(s => s.Title)
                .HasColumnName("title");
        }
    }
}
