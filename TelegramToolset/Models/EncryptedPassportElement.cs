namespace TelegramToolset.Models;

public class EncryptedPassportElement
{
    public string Type { get; set; } = null!;
    public string? Data { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public PassportFile[]? Files { get; set; }
    public PassportFile? FrontSide { get; set; }
    public PassportFile? ReverseSide { get; set; }
    public PassportFile? Selfie { get; set; }
    public PassportFile[]? Translation { get; set; }
    public string Hash { get; set; } = null!;
}