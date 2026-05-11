using LinkedOut.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LinkedOut.Api.Data.Configurations
{
    public class ProfileSkillConfiguration : IEntityTypeConfiguration<ProfileSkill>
    {
        public void Configure(EntityTypeBuilder<ProfileSkill> builder)
        {
            builder.ToTable("profile_skills");

            // Составной ключ
            builder.HasKey(ps => new { ps.ProfileId, ps.SkillId });

            builder.Property(ps => ps.ProfileId)
                .HasColumnName("profile_id");
            builder.Property(ps => ps.SkillId)
                .HasColumnName("skill_id");
            builder.Property(ps => ps.Level)
                .HasColumnName("level");
        }
    }
}
