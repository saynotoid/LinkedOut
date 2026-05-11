namespace LinkedOut.Api.Entities
{
    public class RequirementSkill
    {
        public required Guid RequirementId { get; set; }

        public required Guid SkillId { get; set; }

        public required int Level { get; set; }

        // Navigation properties
        public Requirement? Requirement { get; set; }

        public Skill? Skill { get; set; }
    }
}
