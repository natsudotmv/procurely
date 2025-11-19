namespace Vendor.Core.Model;

public class VendorEntity
{
    public Guid Id { get; set; }               // Unique identifier
    public string Name { get; set; }           // Vendor name
    public string Email { get; set; }          // Contact email
    public string Phone { get; set; }          // Contact phone
    public string Address { get; set; }        // Optional physical address
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}