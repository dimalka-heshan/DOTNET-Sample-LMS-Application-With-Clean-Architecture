using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;


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

        public override void Add(Classes entity)
        {
            _dbContext.Set<Classes>().Add(entity);
        }
        public override void Delete(Classes entity)
        {
            _dbContext.Set<Classes>().Remove(entity);
        }

        public override void Update(Classes entity)
        {
            _dbContext.Set<Classes>().Update(entity);
        }

        public override async Task<IReadOnlyList<Classes>> GetAllAsync()
        {
            return await _dbContext.Set<Classes>().ToListAsync();
        }

        public override async Task<Classes> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Classes>().FirstAsync();
        }

        //public override async Task<Classes> AddAsync(Classes entity)
        //{
        //    await _dbContext.Set<Classes>().AddAsync(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}

        //public override async Task DeleteAsync(Classes entity)
        //{
        //    _dbContext.Set<Classes>().Remove(entity);
        //    await _dbContext.SaveChangesAsync();
        //}



        //public override async Task<Classes> UpdateAsync(Classes entity)
        //{
        //    _dbContext.Entry(entity).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
