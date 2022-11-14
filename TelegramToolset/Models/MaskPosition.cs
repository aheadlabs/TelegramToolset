namespace TelegramToolset.Models;

public class MaskPosition
{
    public string Point { get; set; } = null!;
    public float XShift { get; set; }
    public float YShift { get; set; }
    public float Scale { get; set; }
}