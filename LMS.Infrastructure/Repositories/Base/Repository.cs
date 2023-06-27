using LMS.Core.Repositories.Base;
using LMS.Infrastructure.Data;


namespace LMS.Infrastructure.Repositories.Base
{
    public abstract class Repository<T> : IRepository<T> 
    {
        protected ApplicationDbContext _dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public abstract void Add(T entity);

        public abstract void Delete(T entity);

        public abstract void Update(T entity);

        public abstract Task<IReadOnlyList<T>> GetAllAsync();

        public abstract Task<T> GetByIdAsync(Guid id);

        



        //public virtual Task<T> AddAsync(T entity)
        //{
        //    throw new NotImplementedException();
        //}




        //public virtual Task DeleteAsync(T entity)
        //{
        //    throw new NotImplementedException();
        //}



        //public virtual Task<T> UpdateAsync(T entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
