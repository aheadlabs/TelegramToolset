namespace TelegramToolset.Models;

public class LoginUrl
{
    public string Url { get; set; } = null!;
    public string? ForwardText { get; set; }
    public string? BotUsername { get; set; }
    public bool? RequestWriteAccess { get; set; }
}