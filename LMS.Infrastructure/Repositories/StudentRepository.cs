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
    public class StudentRepository:Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Student> AddAsync(Student entity)
        {
            await _dbContext.Set<Student>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(Student entity)
        {
            _dbContext.Set<Student>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Student>> GetAllAsync()
        {
            return await _dbContext.Set<Student>().ToListAsync();
        }

        public override async Task<Student> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Student>().FirstAsync();
        }

        public override async Task<Student> UpdateAsync(Student entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
