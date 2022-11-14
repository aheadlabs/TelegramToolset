namespace TelegramToolset.Models;

public class Game
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public PhotoSize[] Photo { get; set; } = null!;
    public string? Text { get; set; }
    public MessageEntity[]? TextEntities { get; set; }
    public Animation? Animation { get; set; }
}