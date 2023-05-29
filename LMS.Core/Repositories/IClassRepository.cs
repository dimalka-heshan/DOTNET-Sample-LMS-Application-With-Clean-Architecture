using LMS.Core.Entities;
using LMS.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repositories
{
    public interface IClassRepository:IRepository<Classes>
    {
        //here we have all the custom operations
        Task<IEnumerable<Classes>> GetClassesByName(string name);
    }
}
