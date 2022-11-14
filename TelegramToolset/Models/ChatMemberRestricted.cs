namespace TelegramToolset.Models;

public class ChatMemberRestricted : ChatMember
{
    public bool IsMember { get; set; }
    public bool CanChangeInfo { get; set; }
    public bool CanInviteUsers { get; set; }
    public bool CanPinMessages { get; set; }
    public bool CanManageTopics { get; set; }
    public bool CanSendMessages { get; set; }
    public bool CanSendMediaMessages { get; set; }
    public bool CanSendPolls { get; set; }
    public bool CanSendOtherMessages { get; set; }
    public bool CanAddWebPagePreviews { get; set; }
    public int UntilDate { get; set; }
}