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
    public class ClassesRepository : Repository<Classes>, IClassRepository
    {
        public ClassesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public  async Task<IEnumerable<Classes>> GetClassesByName(string name)
        {
            return await _dbContext.Classes
                .Where(c => c.Name == name)
                .ToListAsync();
        }

        public override async Task<Classes> AddAsync(Classes entity)
        {
            await _dbContext.Set<Classes>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(Classes entity)
        {
            _dbContext.Set<Classes>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public override async Task<IReadOnlyList<Classes>> GetAllAsync()
        {
            return await _dbContext.Set<Classes>().ToListAsync();
        }

        public override async Task<Classes> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Classes>().FirstAsync();
        }

        public override async Task<Classes> UpdateAsync(Classes entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
