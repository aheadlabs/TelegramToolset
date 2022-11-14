namespace TelegramToolset.Models;

public class Voice
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public int Duration { get; set; }
    public string? MimeType { get; set; }
    public int? FileSize { get; set; }
}