namespace LinkedOut.Api.Entities
{
    public class Profile
    {
        public Guid Id { get; set; }

        public required string FullName { get; set; }

        public required string Email { get; set; }

        public string? Headline { get; set; }
    }
}
