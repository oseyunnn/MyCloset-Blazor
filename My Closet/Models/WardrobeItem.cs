namespace MyCloset.Models;

public class WardrobeItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // "Top", "Bottom", "Shoes", "Accessory"
    public string ImagePath { get; set; } = string.Empty;
    public int LayerOrder { get; set; } // Visual layering index
    public bool IsActive { get; set; } = true;
    public DateTime AddedAt { get; set; } = DateTime.UtcNow;

    // Relationship navigation: one item can be part of many outfit suggestions
    public List<OutfitItem> OutfitItems { get; set; } = new();
}