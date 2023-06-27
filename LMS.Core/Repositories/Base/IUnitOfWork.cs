

namespace LMS.Core.Repositories.Base
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(Guid user, CancellationToken cancellationToken = default);
    }
}
