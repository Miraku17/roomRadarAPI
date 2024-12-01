using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }
    [Required]
    public string Email { get; set; } = string.Empty;
    [Required]
    [MinLength(8)]
    public string Password { get; set; } = string.Empty;  // Hashed

    [Required]
    [RegularExpression("^(Landlord|Tenant)$", ErrorMessage = "UserType must be either Landlord or Tenant")]
    public string UserType { get; set; } = string.Empty;  // "Landlord" or "Tenant"

    // Relationships
    public Landlord? Landlord { get; set; }
    public Tenant? Tenant { get; set; }
}