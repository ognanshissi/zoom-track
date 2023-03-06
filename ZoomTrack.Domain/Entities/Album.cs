namespace ZoomTrack.Domain.Entities;

public class Album: Entity
{
    public string Title { get; set; }

    public string Description { get; set; }

    public Author Author { get; set; }

    public IEnumerable<Track> Tracks { get; set; }

    public string ThumbnailImageUrl { get; set; }


    public DateTime ReleasedAtUtc { get; set; }

}
