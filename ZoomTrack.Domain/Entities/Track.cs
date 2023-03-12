using ZoomTrack.Domain.Shared;

namespace ZoomTrack.Domain.Entities;

public sealed class Track : BaseEntity
{

    public Track(Guid id, string title, string? description, DateTime releasedAtUtc, string trackUrl)
        : base(id)
    {
        Title = title;
        Description = description;
        ReleasedAtUtc = releasedAtUtc;
        TrackUrl = trackUrl;
    }

    public string Title { get; set; }

    public string ThumbnailImageUrl { get; set; }

    public string? Description { get; set; }

    public string TrackUrl { get; set; }

    public Guid AuthorId { get; set; }

    public DateTime ReleasedAtUtc { get; set; }


    public Track Create(Guid id, string title, string? description, DateTime releasedAtUtc, string trackUrl, string thumbnailImageUrl, Author author)
    {

        var track = new Track(id, title, description, releasedAtUtc, trackUrl);

        return track;

    }

}
