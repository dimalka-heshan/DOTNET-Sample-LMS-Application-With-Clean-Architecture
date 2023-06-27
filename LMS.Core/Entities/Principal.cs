using LMS.Core.Primitives;


namespace LMS.Core.Entities
{
    public class Principal:IAuditableEntity
    {
        public Principal(Guid PrincipalId, string Name, string Email, string Password)
        {
            this.PrincipalId = PrincipalId;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
        }
        public Guid PrincipalId { get; private set; }
        public string? Name { get; private set; }
        public string? Email { get; private set; }
        public string? Password { get; private set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
