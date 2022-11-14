namespace TelegramToolset.Models;

public class ChatMemberOwner : ChatMember
{
    public bool IsAnonymous { get; set; }
    public string? CustomTitle { get; set; }
}