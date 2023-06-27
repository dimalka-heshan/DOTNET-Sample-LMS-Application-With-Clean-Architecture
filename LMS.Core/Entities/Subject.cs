
using LMS.Core.Primitives;


namespace LMS.Core.Entities
{
    public class Subject:IAuditableEntity
    {
        public Subject(Guid SubjectId, string Name)
        {
            this.SubjectId = SubjectId;
            this.Name = Name;
        }
        public Guid SubjectId { get; private set; }
        public string Name { get; private set; }
        public DateTime Created { get;  set; }
        public Guid CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
