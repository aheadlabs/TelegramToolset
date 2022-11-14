namespace TelegramToolset.Models;

public class InlineKeyboardButton
{
    public string Text { get; set; }
    public string? Url { get; set; }
    public string? CallbackData { get; set; }
    public WebAppInfo? WebApp { get; set; }
    public LoginUrl? LoginUrl { get; set; }
    public string? SwitchInlineQuery { get; set; }
    public string? SwitchInlineQueryCurrentChat { get; set; }
    public CallbackGame? CallbackGame { get; set; }
    public bool? Pay { get; set; }
}