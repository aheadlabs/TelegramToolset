namespace TelegramToolset.Models;

public class ProximityAlertTriggered
{
    public User Traveler { get; set; } = null!;
    public User Watcher { get; set; } = null!;
    public int Distance { get; set; }
}