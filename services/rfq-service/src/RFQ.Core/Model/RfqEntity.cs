namespace RFQ.Core.Model;

public class RfqEntity
{
    public Guid Id { get; set; }           // Unique identifier
    public string RfqNumber { get; set; }  // RFQ reference number
    public string Title { get; set; }      // Short description
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}