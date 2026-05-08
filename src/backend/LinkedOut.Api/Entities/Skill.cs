namespace LinkedOut.Api.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Category { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
