namespace TelegramToolset.Models;

public class PassportData
{
    public EncryptedPassportElement[] Data { get; set; } = null!;
    public EncryptedCredentials Credentials { get; set; } = null!;
}