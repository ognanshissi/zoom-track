using Microsoft.EntityFrameworkCore;
using ZoomTrack.Domain.Entities;

namespace ZoomTrack.Persistence;

public class ApplicationDbContext: DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
	{

	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
	}

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<Entity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAtUtc = DateTime.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedAtUtc = DateTime.UtcNow;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
