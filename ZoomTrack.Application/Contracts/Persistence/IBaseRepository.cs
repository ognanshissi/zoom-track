namespace ZoomTrack.Application.Contracts.Persistence;

public interface IBaseRepository<T> where T : class
{

    Task<T> CreateAsync(T entity, CancellationToken cancellation);

    Task<T> UpdateAsync(T entity, CancellationToken cancellation);

    Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellation);

}
