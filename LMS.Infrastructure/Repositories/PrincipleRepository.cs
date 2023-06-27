using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;


namespace LMS.Infrastructure.Repositories
{
    public class PrincipleRepository:Repository<Principal>,IPrincipalRepository
    {
        public PrincipleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        public override void Add(Principal entity)
        {
            _dbContext.Set<Principal>().Add(entity);
        }
        public override void Delete(Principal entity)
        {
            _dbContext.Set<Principal>().Remove(entity);
        }

        public override void Update(Principal entity)
        {
            _dbContext.Set<Principal>().Update(entity);
        }

        

        public override async Task<IReadOnlyList<Principal>> GetAllAsync()
        {
            return await _dbContext.Set<Principal>().ToListAsync();
        }

        public override async Task<Principal> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Principal>().FirstAsync();
        }


        //public override async Task<Principal> AddAsync(Principal entity)
        //{
        //    await _dbContext.Set<Principal>().AddAsync(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}

        //public override async Task DeleteAsync(Principal entity)
        //{
        //    _dbContext.Set<Principal>().Remove(entity);
        //    await _dbContext.SaveChangesAsync();
        //}
        //public override async Task<Principal> UpdateAsync(Principal entity)
        //{
        //    _dbContext.Entry(entity).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
