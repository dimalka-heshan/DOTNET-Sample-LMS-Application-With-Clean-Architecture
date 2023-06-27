using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;


namespace LMS.Infrastructure.Repositories
{
    public class StudentRepository:Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override void Add(Student entity)
        {
            _dbContext.Set<Student>().Add(entity);
        }
        public override void Delete(Student entity)
        {
            _dbContext.Set<Student>().Remove(entity);
        }

        public override void Update(Student entity)
        {
            _dbContext.Set<Student>().Update(entity);
        }


        
        public override async Task<IReadOnlyList<Student>> GetAllAsync()
        {
            return await _dbContext.Set<Student>().ToListAsync();
        }

        public override async Task<Student> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Student>().FirstAsync();
        }

        


        //public override async Task<Student> AddAsync(Student entity)
        //{
        //    await _dbContext.Set<Student>().AddAsync(entity);
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}

        //public override async Task DeleteAsync(Student entity)
        //{
        //    _dbContext.Set<Student>().Remove(entity);
        //    await _dbContext.SaveChangesAsync();
        //}

        //public override async Task<Student> UpdateAsync(Student entity)
        //{
        //    _dbContext.Entry(entity).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //    return entity;
        //}
    }
}
