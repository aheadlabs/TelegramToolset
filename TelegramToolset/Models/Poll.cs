namespace TelegramToolset.Models;

public class Poll
{
    public string Id { get; set; } = null!;
    public string Question { get; set; } = null!;
    public PollOption[] Options { get; set; } = null!;
    public int TotalVoterCount { get; set; } = 0;
    public bool IsClosed { get; set; }
    public bool IsAnonymous { get; set; }
    public string Type { get; set; } = null!;
    public bool AllowsMultipleAnswers { get; set; }
    public int? CorrectOptionId { get; set; }
    public string? Explanation { get; set; } = null!;
    public MessageEntity[]? ExplanationEntities { get; set; }
    public int? OpenPeriod { get; set; }
    public int? CloseDate { get; set; }
}