namespace MyCloset.Models;

public class OutfitItem
{
    public int Id { get; set; }

    // Foreign key to OutfitSuggestion
    public int OutfitSuggestionId { get; set; }
    public OutfitSuggestion? OutfitSuggestion { get; set; }

    // Foreign key to WardrobeItem
    public int WardrobeItemId { get; set; }
    public WardrobeItem? WardrobeItem { get; set; }
}