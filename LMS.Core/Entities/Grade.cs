
using LMS.Core.Primitives;


namespace LMS.Core.Entities
{
    public class Grade:IAuditableEntity
    {
        public Grade(Guid GradeId, Guid StudentId, Guid SubjectId, double Marks)
        {
            this.GradeId = GradeId;
            this.StudentId = StudentId;
            this.SubjectId = SubjectId;
            this.Marks = Marks;
        }
        public Guid GradeId { get; private set; }
        public Guid StudentId { get; private set; }
        public Guid SubjectId { get; private set; }
        public double Marks { get; private set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
