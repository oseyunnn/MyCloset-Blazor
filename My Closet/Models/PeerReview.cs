namespace MyCloset.Models;

public class PeerReview
{
    public int Id { get; set; }
    public string SenderName { get; set; } = string.Empty;
    public string EventWorked { get; set; } = string.Empty;
    public string EventDate { get; set; } = string.Empty;
    public string LikedReason { get; set; } = string.Empty;
    public string DislikedReason { get; set; } = string.Empty;
    public string GeneralComments { get; set; } = string.Empty;
    public double Rating { get; set; } = 5.0;
    
    public bool IsApproved { get; set; } = true; // Admin moderation flag
    public bool IsFeatured { get; set; } = false;
    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
}