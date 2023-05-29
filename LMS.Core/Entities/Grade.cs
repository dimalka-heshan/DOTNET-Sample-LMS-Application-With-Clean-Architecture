
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Entities
{
    public class Grade
    {

        public Guid GradeId { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public int Marks { get; set; }
    }
}
