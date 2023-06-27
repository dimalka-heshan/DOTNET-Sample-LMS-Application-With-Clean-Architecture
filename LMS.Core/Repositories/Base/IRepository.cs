
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repositories.Base
{
    public interface IRepository<T> 
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //Task<T> AddAsync(T entity);
        //Task<T> UpdateAsync(T entity);
        //Task DeleteAsync(T entity);

    }
}
