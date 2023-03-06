
namespace ZoomTrack.Domain.Entities;
public class Track
{

    public Track(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public string Title { get; set; }

    public string Description { get; set; }
}
