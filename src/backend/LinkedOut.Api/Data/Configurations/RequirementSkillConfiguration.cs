using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkedOut.Api.Data.Configurations
{
    public class RequirementSkillConfiguration : IEntityTypeConfiguration<RequirementSkill>
    {
        public void Configure(EntityTypeBuilder<RequirementSkill> builder)
        {
            builder.ToTable("requirement_skills");

            // Составной ключ
            builder.HasKey(rs => new { rs.RequirementId, rs.SkillId });

            builder.Property(rs => rs.RequirementId)
                .HasColumnName("requirement_id");
            builder.Property(rs => rs.SkillId)
                .HasColumnName("skill_id");
            builder.Property(rs => rs.Level)
                .HasColumnName("level");
        }
    }
}
