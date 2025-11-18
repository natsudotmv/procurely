namespace Analytics.Core.Model;

public class AnalyticsEntity
{
    public int Id { get; set; }                   // PK
    public string EventType { get; set; }         // e.g., "PurchaseOrderCreated", "QuoteViewed"
    public string UserId { get; set; }            // Which user or company performed it
    public DateTime CreatedAt { get; set; }       // Timestamp
}