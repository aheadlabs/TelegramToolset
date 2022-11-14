namespace TelegramToolset.Models;

public class PollAnswer
{
    public string PollId { get; set; } = null!;
    public User User { get; set; } = null!;
    public int[] OptionIds { get; set; } = null!;
}