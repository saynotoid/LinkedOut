namespace LinkedOut.Api.Entities
{
    public class Requirement
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public required string Title { get; set; }

        // Navigation properties
        public Company? Company { get; set; }
    }
}
