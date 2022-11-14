namespace TelegramToolset.Models;

/// <summary>
/// The file can be downloaded via the link https://api.telegram.org/file/bot{token}{file_path}
/// </summary>
public class File
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public int? FileSize { get; set; }
    public string? FilePath { get; set; }
}