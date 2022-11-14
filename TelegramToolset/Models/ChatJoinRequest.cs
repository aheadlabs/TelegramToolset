namespace TelegramToolset.Models;

public class ChatJoinRequest
{
    public Chat Chat { get; set; } = null!;
    public User From { get; set; } = null!;
    public int Date { get; set; }
    public string? Bio { get; set; }
    public ChatInviteLink? InviteLink { get; set; }
}