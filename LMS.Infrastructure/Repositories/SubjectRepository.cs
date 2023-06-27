using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;


namespace LMS.Infrastructure.Repositories
{
    public class SubjectRepository:Repository<Subject>,ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override void Add(Subject entity)
        {
            _dbContext.Set<Subject>().Add(entity);
        }
        public override void Delete(Subject entity)
        {
            _dbContext.Set<Subject>().Remove(entity);
        }

        public override void Update(Subject entity)
        {
            _dbContext.Set<Subject>().Update(entity);
        }

        

        public override async Task<IReadOnlyList<Subject>> GetAllAsync()
        {
            return await _dbContext.Set<Subject>().ToListAsync();
        }

        public override async Task<Subject> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Subject>().FirstAsync();
        }

        //public override async Task<Subject> AddAsync(Subject entity)
        //{
        //    await _dbContext.Set<Subject>().AddAsync(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}

        //public override async Task DeleteAsync(Subject entity)
        //{
        //    _dbContext.Set<Subject>().Remove(entity);
        //    await _dbContext.SaveChangesAsync();
        //}

        //public override async Task<Subject> UpdateAsync(Subject entity)
        //{
        //    _dbContext.Entry(entity).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
