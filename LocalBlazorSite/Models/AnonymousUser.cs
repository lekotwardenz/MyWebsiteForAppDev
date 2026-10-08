public class AnonymousUser
{
    public string SessionId { get; set; } = Guid.NewGuid().ToString();
    public string IpAddress { get; set; } = string.Empty;
    public string GeneratedDisplayName { get; set; } = string.Empty;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;

    // Navigation properties for relationships
    public ICollection<Post> Posts { get; set; } = new List<Post>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}