namespace LinkedOut.Api.Entities
{
    public class Company
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Location { get; set; }
    }
}
