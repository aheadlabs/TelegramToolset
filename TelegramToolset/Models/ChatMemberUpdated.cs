namespace TelegramToolset.Models;

public class ChatMemberUpdated
{
    public Chat Chat { get; set; } = null!;
    public User From { get; set; } = null!;
    public int Date { get; set; }
    public ChatMember OldChatMember { get; set; } = null!;
    public ChatMember NewChatMember { get; set; } = null!;
    public ChatInviteLink? InviteLink { get; set; }
}