namespace zgstumpf_Assignment3.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? ImdbHyperlink { get; set; }
        public string? Genre { get; set; }
        public string? ReleaseYear { get; set; }
        public string? MediaUrl { get; set; }

    }
}
