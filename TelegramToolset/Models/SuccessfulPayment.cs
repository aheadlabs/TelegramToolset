namespace TelegramToolset.Models;

public class SuccessfulPayment
{
    public string Currency { get; set; } = null!;
    public int TotalAmount { get; set; }
    public string InvoicePayload { get; set; } = null!;
    public string? ShippingOptionId { get; set; } = null!;
    public OrderInfo? OrderInfo { get; set; } = null!;
    public string TelegramPaymentChargeId { get; set; } = null!;
    public string ProviderPaymentChargeId { get; set; } = null!;
}