public class Game
{
    public string GameId { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Developer { get; set; } = string.Empty;

    // Navigation properties
    public ICollection<Post> Posts { get; set; } = new List<Post>();
    public ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    // Implemented method from diagram
    public float GetAverageRating()
    {
        if (Ratings == null || !Ratings.Any()) return 0f;
        return (float)Ratings.Average(r => r.Score);
    }
}