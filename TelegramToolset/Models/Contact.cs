namespace TelegramToolset.Models;

public class Contact
{
    public string PhoneNumber { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    public int? UserId { get; set; }
    public int? Vcard { get; set; }
}