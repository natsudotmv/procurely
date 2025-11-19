namespace Notification.Core.Model;

public class NotificationEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();  // Primary key

    public Guid UserId { get; set; }                // Recipient user (optional if system-wide)
    public string? Title { get; set; }              // Notification title
    public string Message { get; set; } = default!; // Main content

    public bool IsRead { get; set; } = false;      // Track if user has read it
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ReadAt { get; set; }          // Timestamp when read

    // Optional: type of notification (Email, Push, SMS, etc.)
    public string? Type { get; set; } = "System";
}