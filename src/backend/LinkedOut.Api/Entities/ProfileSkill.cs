namespace LinkedOut.Api.Entities
{
    public class ProfileSkill
    {
        public Guid ProfileId { get; set; }

        public Guid SkillId { get; set; }

        public int Level { get; set; }

        // Navigation properties
        public Profile? Profile { get; set; }

        public Skill? Skill { get; set; }
    }
}
