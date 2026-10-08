namespace MyCloset.Models;

public class InteractivePhrase
{
    public int Id { get; set; }
    public string PhraseText { get; set; } = string.Empty;
    
    // Identifies target bubble: "HomeHero" or "AboutGirl"
    public string ContextTag { get; set; } = string.Empty; 
    public bool IsActive { get; set; } = true;
}