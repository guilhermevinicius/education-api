using Education.Domain.SeedWork;

namespace Education.Infra.Data.Repositories;

public class UnitOfWork(DataContext context) : IUnitOfWork
{
    public async Task<bool> CommitAsync(CancellationToken cancellationToken)
    {
        return await context.SaveChangesAsync(cancellationToken) > 0;
    }
}