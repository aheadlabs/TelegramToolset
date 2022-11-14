namespace TelegramToolset.Models;

public class OrderInfo
{
    public string Name { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public ShippingAddress ShippingAddress { get; set; } = null!;
}