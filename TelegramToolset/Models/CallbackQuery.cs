namespace TelegramToolset.Models;

public class CallbackQuery
{
    public string Id { get; set; } = null!;
    public User From { get; set; } = null!;
    public Message? Message { get; set; }
    public string? InlineMessageId { get; set; }
    public string? ChatInstance { get; set; }
    public string? Data { get; set; }
    public string? GameShortName { get; set; }
}