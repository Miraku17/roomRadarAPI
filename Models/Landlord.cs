public class Landlord
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ValidIdImageUrl { get; set; } = string.Empty;
    public string CertificateOfTitleImageUrl { get; set; } = string.Empty;



    // One landlord can have many properties
    // public List<Property> Properties { get; set; } = new();
}