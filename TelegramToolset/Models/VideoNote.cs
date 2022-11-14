namespace TelegramToolset.Models;

public class VideoNote
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public int Length { get; set; }
    public int Duration { get; set; }
    public PhotoSize? Thumb { get; set; }
    public int? FileSize { get; set; }
}