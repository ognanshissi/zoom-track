using ZoomTrack.Domain.Shared;

namespace ZoomTrack.Domain.Entities;

public class Author : BaseEntity
{
    internal protected Author(Guid id, string firstName, string lastName) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    /// <summary>
    /// Create Author factory
    /// </summary>
    /// <param name="id"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <returns></returns>
    public Author Create(Guid id, string firstName, string lastName)
    {
        var author = new Author(id, firstName, lastName);

        return author;
    }
}
