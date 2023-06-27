
using LMS.Core.Primitives;
using System.ComponentModel.DataAnnotations;

namespace LMS.Core.Entities
{
    public class Classes:IAuditableEntity
    {

        public Classes(Guid ClassId, string Name, Guid TeacherId)
        {
            this.ClassId = ClassId;
            this.Name = Name;
            this.TeacherId = TeacherId;

        }

        [Key]
        public Guid ClassId { get; private set; }
        public string Name { get; private set; }
        public Guid TeacherId { get; private set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
