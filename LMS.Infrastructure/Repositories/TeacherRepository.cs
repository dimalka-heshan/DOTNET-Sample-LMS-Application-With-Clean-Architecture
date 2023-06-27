using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;


namespace LMS.Infrastructure.Repositories
{
    public class TeacherRepository:Repository<Teacher>,ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override void Add(Teacher entity)
        {
            _dbContext.Set<Teacher>().Add(entity);
        }
        public override void Delete(Teacher entity)
        {
            _dbContext.Set<Teacher>().Remove(entity);
        }

        public override void Update(Teacher entity)
        {
            _dbContext.Set<Teacher>().Update(entity);
        }


        

        public override async Task<IReadOnlyList<Teacher>> GetAllAsync()
        {
            return await _dbContext.Set<Teacher>().ToListAsync();
        }

        public override async Task<Teacher> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Teacher>().FirstAsync();
        }

        //public override async Task<Teacher> AddAsync(Teacher entity)
        //{
        //    await _dbContext.Set<Teacher>().AddAsync(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}

        //public override async Task DeleteAsync(Teacher entity)
        //{
        //    _dbContext.Set<Teacher>().Remove(entity);
        //    await _dbContext.SaveChangesAsync();
        //}
        //public override async Task<Teacher> UpdateAsync(Teacher entity)
        //{
        //    _dbContext.Entry(entity).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
