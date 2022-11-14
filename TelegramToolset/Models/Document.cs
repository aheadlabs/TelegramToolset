namespace TelegramToolset.Models;

public class Document
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public PhotoSize? Thumb { get; set; }
    public string? FileName { get; set; }
    public string? MimeType { get; set; }
    public int? FileSize { get; set; }
}