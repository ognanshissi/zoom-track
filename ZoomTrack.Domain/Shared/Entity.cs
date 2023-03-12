namespace ZoomTrack.Domain.Shared;

public abstract class BaseEntity: IEquatable<BaseEntity>
{

    public BaseEntity(Guid id)
    {
        Id = id;
    }

    // The init is use because the Id is set once and is not
    // editable in the lifecycle of the Class
    public Guid Id { get; private init; }

    public override int GetHashCode()
    {
        return Id.GetHashCode() * 120;
    }

    public bool Equals(BaseEntity? other)
    {
        if (other is null)
        {
            return false;
        }

        if (other.GetType() != GetType())
        {
            return false;
        }

        return other.Id == Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        if (obj is not BaseEntity entity)
        {
            return false;
        }

        return entity.Id == Id;
    }
}
