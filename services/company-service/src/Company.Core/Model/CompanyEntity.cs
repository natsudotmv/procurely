namespace Company.Core.Model;

public class CompanyEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();   // Primary Key

    public string Name { get; set; }                 // Company name

    public string? RegistrationNumber { get; set; }  // Gov/business reg number (optional)

    public string? Email { get; set; }               // Official email
    public string? Phone { get; set; }               // Contact number

    public string? Address { get; set; }             // Physical address

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}