public class Post
{
    public string PostId { get; set; } = Guid.NewGuid().ToString();
    public string Content { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public int Upvotes { get; set; }

    // Foreign Keys & Relationships
    public string AnonymousUserId { get; set; } = string.Empty;
    public AnonymousUser? AnonymousUser { get; set; }

    public string GameId { get; set; } = string.Empty;
    public Game? Game { get; set; }

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}