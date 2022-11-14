namespace TelegramToolset.Models;

public class Sticker
{
    public string FileId { get; set; } = null!;
    public string FileUniqueId { get; set; } = null!;
    public string Type { get; set; } = null!;
    public int Width { get; set; }
    public int Height { get; set; }
    public bool IsAnimated { get; set; }
    public bool IsVideo { get; set; }
    public PhotoSize? Thumb { get; set; }
    public string? Emoji { get; set; }
    public string? SetName { get; set; }
    public File? PremiumAnimation { get; set; }
    public MaskPosition? MaskPosition { get; set; }
    public string? CustomEmojiId { get; set; }
    public int? FileSize { get; set; }
}