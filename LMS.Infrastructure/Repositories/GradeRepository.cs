﻿using LMS.Core.Entities;
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
    public class GradeRepository:Repository<Grade>,IGradeRepository
    {
        public GradeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Grade> AddAsync(Grade entity)
        {
            await _dbContext.Set<Grade>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public override async Task DeleteAsync(Grade entity)
        {
            _dbContext.Set<Grade>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public override async Task<IReadOnlyList<Grade>> GetAllAsync()
        {
            return await _dbContext.Set<Grade>().ToListAsync();
        }

        public override async Task<Grade> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Grade>().FirstAsync();
        }

        public IEnumerable<Grade> GetGradesByStudentId(Guid studentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grade> GetGradesBySubjectId(Guid subjectId)
        {
            throw new NotImplementedException();
        }

        public override async Task<Grade> UpdateAsync(Grade entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
