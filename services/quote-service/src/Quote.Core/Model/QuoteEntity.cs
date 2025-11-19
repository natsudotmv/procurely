namespace Quote.Core.Model;

public class QuoteEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();      // Primary key

    public Guid CustomerId { get; set; }                // Customer requesting the quote
    public Guid CompanyId { get; set; }                 // Company providing the quote
    public Guid? OrderId { get; set; }                  // Optional: related order

    public string QuoteNumber { get; set; } = default!; // e.g., "Q-20251119-001"
    public DateTime QuoteDate { get; set; } = DateTime.UtcNow;

    public decimal TotalAmount { get; set; }           // Total quoted amount
    public string Currency { get; set; } = "USD";      // Currency code

    public string Status { get; set; } = "Pending";    // e.g., Pending, Accepted, Rejected

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}