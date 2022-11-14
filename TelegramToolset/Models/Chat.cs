namespace TelegramToolset.Models;

public class Chat
{
    public int Id { get; set; }
    public string Type { get; set; } = null!;
    public string? Title { get; set; }
    public string? Username { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public bool? IsForum { get; set; }
    public ChatPhoto? Photo { get; set; }
    public string[]? ActiveUsernames { get; set; }
    public string? EmojiStatusCustomEmojiId { get; set; }
    public string? Bio { get; set; }
    public bool? HasPrivateForwards { get; set; }
    public bool? HasRestrictedVoiceAndVideoMessages { get; set; }
    public bool? JoinToSendMessages { get; set; }
    public bool? JoinByRequest { get; set; }
    public string? Description { get; set; }
    public string? InviteLink { get; set; }
    public Message? PinnedMessage { get; set; }
    public ChatPermissions? Permissions { get; set; }
    public int? SlowModeDelay { get; set; }
    public int? MessageAutoDeleteTime { get; set; }
    public bool? HasProtectedContent { get; set; }
    public string? StickerSetName { get; set; }
    public bool? CanSetStickerSet { get; set; }
    public int? LinkedChatId { get; set; }
    public ChatLocation? Location { get; set; }
}