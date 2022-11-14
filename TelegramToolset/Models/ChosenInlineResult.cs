namespace TelegramToolset.Models;

public class ChosenInlineResult
{
    public string ResultId { get; set; } = null!;
    public User From { get; set; } = null!;
    public Location? Location { get; set; }
    public string? InlineMessageId { get; set; }
    public string Query { get; set; } = null!;
}