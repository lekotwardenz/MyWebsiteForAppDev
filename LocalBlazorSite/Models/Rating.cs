public class Rating
{
    public string RatingId { get; set; } = Guid.NewGuid().ToString();
    public double Score { get; set; } 
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    // Foreign Keys & Relationships
    public string AnonymousUserId { get; set; } = string.Empty;
    public AnonymousUser? AnonymousUser { get; set; }

    public string GameId { get; set; } = string.Empty;
    public Game? Game { get; set; }
}