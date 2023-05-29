using LMS.Core.Entities;
using LMS.Core.Repositories;
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
    public class SubjectRepository:Repository<Subject>,ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Subject> AddAsync(Subject entity)
        {
            await _dbContext.Set<Subject>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(Subject entity)
        {
            _dbContext.Set<Subject>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public override async Task<IReadOnlyList<Subject>> GetAllAsync()
        {
            return await _dbContext.Set<Subject>().ToListAsync();
        }

        public override async Task<Subject> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Subject>().FirstAsync();
        }

        public override async Task<Subject> UpdateAsync(Subject entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
