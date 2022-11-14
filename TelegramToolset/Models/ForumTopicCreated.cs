namespace TelegramToolset.Models;

public class ForumTopicCreated
{
    public string Name { get; set; } = null!;
    public int IconColor { get; set; }
    public string? IconCustomEmojiId { get; set; }
}