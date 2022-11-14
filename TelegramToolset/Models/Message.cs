namespace TelegramToolset.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int? MessageThreadId { get; set; }
        public User? From { get; set; }
        public Chat? SenderChat { get; set; }
        public int Date { get; set; }
        public Chat Chat { get; set; } = null!;
        public User? ForwardFrom { get; set; }
        public Chat? ForwardFromChat { get; set; }
        public int? ForwardFromMessageId { get; set; }
        public string? ForwardSignature { get; set; }
        public string? ForwardSenderName { get; set; }
        public int? ForwardDate { get; set; }
        public bool? IsTopicMessage { get; set; }
        public bool? IsAutomaticForward { get; set; }
        public Message? ReplyToMessage { get; set; }
        public User? ViaBot { get; set; }
        public int? EditDate { get; set; }
        public bool? HasProtectedContent { get; set; }
        public string? MediaGroupId { get; set; }
        public string? AuthorSignature { get; set; }
        public string? Text { get; set; }
        public MessageEntity[]? Entities { get; set; }
        public Animation? Animation { get; set; }
        public Audio? Audio { get; set; }
        public Document? Document { get; set; }
        public PhotoSize[]? Photo { get; set; }
        public Sticker? Sticker { get; set; }
        public Video? Video { get; set; }
        public VideoNote? VideoNote { get; set; }
        public Voice? Voice { get; set; }
        public string? Caption { get; set; }
        public MessageEntity[]? CaptionEntities { get; set; }
        public Contact? Contact { get; set; }
        public Dice? Dice { get; set; }
        public Game? Game { get; set; }
        public Poll? Poll { get; set; }
        public Venue? Venue { get; set; }
        public Location? Location { get; set; }
        public User[]? NewChatMembers { get; set; }
        public User? LeftChatMember { get; set; }
        public string? NewChatTitle { get; set; }
        public PhotoSize[]? NewChatPhoto { get; set; }
        public bool? DeleteChatPhoto { get; set; }
        public bool? GroupChatCreated { get; set; }
        public bool? SupergroupChatCreated { get; set; }
        public bool? ChannelChatCreated { get; set; }
        public MessageAutoDeleteTimerChanged? MessageAutoDeleteTimerChanged { get; set; }
        public int? MigrateToChatId { get; set; }
        public int? MigrateFromChatId { get; set; }
        public Message? PinnedMessage { get; set; }
        public Invoice? Invoice { get; set; }
        public SuccessfulPayment? SuccessfulPayment { get; set; }
        public string? ConnectedWebsite { get; set; }
        public PassportData? PassportData { get; set; }
        public ProximityAlertTriggered? ProximityAlertTriggered { get; set; }
        public ForumTopicCreated? ForumTopicCreated { get; set; }
        public ForumTopicClosed? ForumTopicClosed { get; set; }
        public ForumTopicReopened? ForumTopicReopened { get; set; }
        public VideoChatScheduled? VideoChatScheduled { get; set; }
        public VideoChatStarted? VideoChatStarted { get; set; }
        public VideoChatEnded? VideoChatEnded { get; set; }
        public VideoChatParticipantsInvited? VideoChatParticipantsInvited { get; set; }
        public WebAppData? WebAppData { get; set; }
        public InlineKeyboardMarkup? ReplyMarkup { get; set; }
    }
}
