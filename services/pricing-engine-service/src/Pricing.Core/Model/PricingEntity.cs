namespace Pricing.Core.Model;

public class PricingEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();   // Primary key

    public Guid ProductId { get; set; }              // Reference to the product or service
    public Guid CompanyId { get; set; }              // Optional: which company owns this price

    public decimal Amount { get; set; }              // Price amount
    public string Currency { get; set; } = "USD";    // Currency code

    public DateTime EffectiveFrom { get; set; } = DateTime.UtcNow; // When this price starts
    public DateTime? EffectiveTo { get; set; }       // Optional: end date

    public bool IsActive { get; set; } = true;      // Track if this price is currently active

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}