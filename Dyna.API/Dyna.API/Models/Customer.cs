namespace Dyna.API.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedDate { get; set; } = default(DateTime?);
        public DateTime? LastUpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
