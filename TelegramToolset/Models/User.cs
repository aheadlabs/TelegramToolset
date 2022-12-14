namespace TelegramToolset.Models;

public class User
{
    public int Id { get; set; }
    public bool IsBot { get; set; }
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string? LanguageCode { get; set; }
    public bool? IsPremium { get; set; }
    public bool? AddedToAttachmentMenu { get; set; }
    public bool? CanJoinGroups { get; set; }
    public bool? CanReadAllGroupMessages { get; set; }
    public bool? SupportsInlineQueries { get; set; }
}