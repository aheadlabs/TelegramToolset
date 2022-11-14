namespace TelegramToolset.Models;

public class Audio
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public int Duration { get; set; }
    public string? Performer { get; set; }
    public string? Title { get; set; }
    public string? FileName { get; set; }
    public string? MimeType { get; set; }
    public int? FileSize { get; set; }
    public PhotoSize? Thumb { get; set; }
}