namespace Order.Core.Model;

public class OrderEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();   // Primary key

    public Guid CustomerId { get; set; }             // Reference to the user/customer
    public Guid CompanyId { get; set; }              // Reference to the company placing the order

    public string OrderNumber { get; set; } = default!; // e.g., "ORD-20251119-001"
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public decimal TotalAmount { get; set; }        // Total price of the order
    public string Currency { get; set; } = "USD";   // Currency code

    public string Status { get; set; } = "Pending"; // e.g., Pending, Confirmed, Shipped, Delivered

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}