namespace MyCloset.Models;

public class OutfitSuggestion
{
    public int Id { get; set; }
    public string SuggestedBy { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

    // Relationship navigation: one outfit suggestion consists of multiple items
    public List<OutfitItem> Items { get; set; } = new();
}