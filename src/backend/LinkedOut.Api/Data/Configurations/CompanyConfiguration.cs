using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkedOut.Api.Data.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("companies");

            builder.Property(s => s.Id)
                .HasColumnName("id");
            builder.Property(s => s.Name)
                .HasColumnName("name");
            builder.Property(s => s.Location)
                .HasColumnName("location");
        }
    }
}
