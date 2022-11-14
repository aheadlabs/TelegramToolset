namespace TelegramToolset.Models;

public class PhotoSize
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public int Width { get; set; }
    public int Height { get; set; }
    public int? FileSize { get; set; }
}