using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkedOut.Api.Data.Configurations
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("skills");

            builder.Property(s => s.Id)
                .HasColumnName("id");
            builder.Property(s => s.Name)
                .HasColumnName("name");
            builder.Property(s => s.Category)
                .HasColumnName("category");
            builder.Property(s => s.CreatedAt)
                .HasColumnName("created_at")
                .HasDefaultValueSql("now()")
                .ValueGeneratedOnAdd();
        }
    }
}
