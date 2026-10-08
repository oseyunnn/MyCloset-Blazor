namespace MyCloset.Models;

public class WorkItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // e.g., "Game Narrative", "Software for Good"
    public string Description { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}