﻿namespace TelegramToolset.Models;

public class MessageEntity
{
    public string Type { get; set; } = null!;
    public int Offset { get; set; }
    public int Length { get; set; }
    public string? Url { get; set; }
    public User? User { get; set; }
    public string? Language { get; set; }
    public string? CustomEmojiId { get; set; }
}