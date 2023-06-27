using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;


namespace LMS.Infrastructure.Repositories
{
    public class AdministratorRepository : Repository<Administrator>, IAdministratorRepository
    {
        public AdministratorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override void Add(Administrator entity)
        {
            _dbContext.Set<Administrator>().Add(entity);
        }
        public override  void Delete(Administrator entity)
        {
            _dbContext.Set<Administrator>().Remove(entity);
        }
        public override async Task<IReadOnlyList<Administrator>> GetAllAsync()
        {
            return await _dbContext.Set<Administrator>().ToListAsync();
        }

        public override async Task<Administrator> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Administrator>().FirstAsync();
        }

        public override void Update(Administrator entity)
        {
            _dbContext.Set<Administrator>().Update(entity);
        }

        //public override async Task<Administrator> AddAsync(Administrator entity)
        //{
        //    await _dbContext.Set<Administrator>().AddAsync(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}

        //public override async Task DeleteAsync(Administrator entity)
        //{
        //    _dbContext.Set<Administrator>().Remove(entity);
        //    await _dbContext.SaveChangesAsync();
        //}

        //public  async Task<Administrator> UpdateAsync(Administrator entity)
        //{
        //    _dbContext.Entry(entity).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
