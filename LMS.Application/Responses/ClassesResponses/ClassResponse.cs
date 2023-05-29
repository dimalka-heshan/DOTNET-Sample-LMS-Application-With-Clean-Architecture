using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Responses.ClassesResponses
{
    public class ClassResponse
    {
        public Guid ClassId { get; set; }
        public string Name { get; set; }
        public Guid TeacherId { get; set; }
    }
}
