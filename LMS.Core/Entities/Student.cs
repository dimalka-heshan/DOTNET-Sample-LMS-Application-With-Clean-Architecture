
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Entities
{
    public class Student
    {
        
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactDetails { get; set; }
        public string Email { get; set; }
    }
}
