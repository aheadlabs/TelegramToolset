namespace TelegramToolset.Models;

public class InlineQuery
{
    public string Id { get; set; } = null!;
    public User From { get; set; }
    public string Query { get; set; } = null!;
    public string Offset { get; set; } = null!;
    public string? ChatType { get; set; }
    public Location? Location { get; set; }
}