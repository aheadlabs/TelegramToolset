namespace TelegramToolset.Models;

public class PassportFile
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public int FileSize { get; set; }
    public int FileDate { get; set; }
}