public class Tenant
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    // Many-to-Many: Tenants can have many saved/favorite properties
    // public List<Property> SavedProperties { get; set; } = new();
    // // One-to-Many: Tenant can have many rental applications
    // public List<RentalApplication> RentalApplications { get; set; } = new();
}
