
using LMS.Core.Primitives;


namespace LMS.Core.Entities
{
    public class Student:IAuditableEntity
    {
        public Student(Guid StudentId, string Name, DateTime DateOfBirth, string ContactDetails, string Email)
        {
            this.StudentId = StudentId;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.ContactDetails = ContactDetails;
            this.Email = Email;
        }
        public Guid StudentId { get; private set; }
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string ContactDetails { get; private set; }
        public string Email { get; private set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
