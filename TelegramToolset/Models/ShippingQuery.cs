namespace TelegramToolset.Models;

public class ShippingQuery
{
    public string Id { get; set; } = null!;
    public User From { get; set; } = null!;
    public string InvoicePayload { get; set; } = null!;
    public ShippingAddress ShippingAddress { get; set; } = null!;
}