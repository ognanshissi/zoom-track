using ZoomTrack.Application.Contracts.Persistence;

namespace ZoomTrack.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    public Task<T> CreateAsync(T entity, CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity, CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }
}
