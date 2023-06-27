using LMS.Core.Primitives;
using LMS.Core.Repositories.Base;
using LMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LMS.Infrastructures
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task SaveChangesAsync(Guid user, CancellationToken cancellationToken = default)
        {
            UpdateAuditableEntities(user);
            return _dbContext.SaveChangesAsync(cancellationToken);
        }

        private void UpdateAuditableEntities(Guid user)
        {
            IEnumerable<EntityEntry<IAuditableEntity>> entities = _dbContext.ChangeTracker.Entries<IAuditableEntity>();

            foreach (EntityEntry<IAuditableEntity> entityEntry in entities)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property(a => a.Created).CurrentValue = DateTime.UtcNow;
                    entityEntry.Property(a => a.CreatedBy).CurrentValue = user;
                }

                if (entityEntry.State == EntityState.Modified)
                {
                    entityEntry.Property(a => a.Modified).CurrentValue = DateTime.UtcNow;
                    entityEntry.Property(a => a.ModifiedBy).CurrentValue = user;
                }
            }
        }
    }
}
