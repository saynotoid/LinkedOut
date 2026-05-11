using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkedOut.Api.Data.Configurations
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable("profiles");

            builder.Property(p => p.Id)
                .HasColumnName("id");
            builder.Property(p => p.FullName)
                .HasColumnName("full_name");
            builder.Property(p => p.Email)
                .HasColumnName("email");
            builder.Property(p => p.Headline)
                .HasColumnName("headline");
        }
    }
}
