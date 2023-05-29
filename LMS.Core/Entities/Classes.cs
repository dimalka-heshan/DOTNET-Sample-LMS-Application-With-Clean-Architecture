
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Entities
{
    public class Classes
    {

        public Guid ClassId { get; set; }
        public string Name { get; set; }
        public Guid TeacherId { get; set; }
    }
}
