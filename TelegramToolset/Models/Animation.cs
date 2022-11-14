namespace TelegramToolset.Models;

public class Animation
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public int Width { get; set; }
    public int Height { get; set; }
    public int Duration { get; set; }
    public PhotoSize? Thumb { get; set; }
    public string? FileName { get; set; }
    public string? MimeType { get; set; }
    public int? FileSize { get; set; }
}