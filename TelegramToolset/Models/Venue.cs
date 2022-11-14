namespace TelegramToolset.Models;

public class Venue
{
    public Location Location { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string? FoursquareId { get; set; }
    public string? FourSquareType { get; set; }
    public string? GooglePlaceId { get; set; }
    public string? GooglePlaceType { get; set; }
}