namespace ZoomTrack.Domain.Entities;

public class Track: Entity
{

    public Track(string title, string description)
    {
        Title = title;
        Description = description;
        CreatedAtUtc = DateTime.UtcNow;
    }

    public string Title { get; set; }

    public string ThumbnailImageUrl { get; set; }

    public string Description { get; set; }

    public string TrackUrl { get; set; }

    public DateTime ReleasedAtUtc { get; set; }

}
