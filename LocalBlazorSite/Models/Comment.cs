public class Comment
{
    public string CommentId { get; set; } = Guid.NewGuid().ToString();
    public string Text { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    // Foreign Keys & Relationships
    public string AnonymousUserId { get; set; } = string.Empty;
    public AnonymousUser? AnonymousUser { get; set; }

    public string PostId { get; set; } = string.Empty;
    public Post? Post { get; set; }
}