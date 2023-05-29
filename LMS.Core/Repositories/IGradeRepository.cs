using LMS.Core.Entities;
using LMS.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repositories
{
    public interface IGradeRepository:IRepository<Grade>
    {
        IEnumerable<Grade> GetGradesByStudentId(Guid studentId);
        IEnumerable<Grade> GetGradesBySubjectId(Guid subjectId);
    }
}
