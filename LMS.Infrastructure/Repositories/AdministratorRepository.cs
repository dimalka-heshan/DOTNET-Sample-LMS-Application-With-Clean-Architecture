using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Core.Repositories.Base;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructure.Repositories
{
    public class AdministratorRepository : Repository<Administrator>, IAdministratorRepository
    {
        public AdministratorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Administrator> AddAsync(Administrator entity)
        {
            await _dbContext.Set<Administrator>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(Administrator entity)
        {
            _dbContext.Set<Administrator>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public override async Task<IReadOnlyList<Administrator>> GetAllAsync()
        {
            return await _dbContext.Set<Administrator>().ToListAsync();
        }

        public override async Task<Administrator> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Administrator>().FirstAsync();
        }

        public override async Task<Administrator> UpdateAsync(Administrator entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
