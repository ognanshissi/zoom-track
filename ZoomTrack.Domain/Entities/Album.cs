using ZoomTrack.Domain.Shared;

namespace ZoomTrack.Domain.Entities;

public class Album : BaseEntity
{

    private readonly List<Track> _tracks = new();

    private Album(
        Guid id,
        string title,
        string description,
        Author author,
        string thumbnailImageUrl,
        DateTime releasedAtUtc)
        : base(id)
    {
        Title = title;
        Description = description;
        AuthorId = author.Id;
    }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public Guid AuthorId { get; private set; }

    public IReadOnlyCollection<Track> Tracks => _tracks;

    public string ThumbnailImageUrl { get; private set; }

    public DateTime ReleasedAtUtc { get; private set; }


    public Album Create(Guid id, string title, string description, Author author, string thumbnailImageUrl, DateTime releasedAtUtc)
    {

        Album album = new Album(id, title, description, author, thumbnailImageUrl, releasedAtUtc);


        return album;
    }
}
