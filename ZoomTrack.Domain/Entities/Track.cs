namespace ZoomTrack.Domain.Entities;

public class Track: Entity
{

    internal Track(string title, string? description, DateTime releasedAtUtc, string trackUrl)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        ReleasedAtUtc =  releasedAtUtc;
        TrackUrl = trackUrl;
        CreatedAtUtc = DateTime.UtcNow;
    }

    public string Title { get; set; }

    public string ThumbnailImageUrl { get; set; }

    public string? Description { get; set; }

    public string TrackUrl { get; set; }

    public Author Author { get; set; }

    public DateTime ReleasedAtUtc { get; set; }


    public void Create(string title, string? description, DateTime releasedAtUtc, string trackUrl, string thumbnailImageUrl, Author author)
    {

        var track = new Track(title, description, releasedAtUtc, trackUrl);



    }

}
