using LMS.Core.Entities;
using LMS.Core.Repositories.Base;


namespace LMS.Core.Repositories
{
    public interface IGradeRepository:IRepository<Grade>
    {
        IEnumerable<Grade> GetGradesByStudentId(Guid studentId);
        IEnumerable<Grade> GetGradesBySubjectId(Guid subjectId);
    }
}
