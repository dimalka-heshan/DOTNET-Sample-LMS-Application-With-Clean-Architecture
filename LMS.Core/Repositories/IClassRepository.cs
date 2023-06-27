using LMS.Core.Entities;
using LMS.Core.Repositories.Base;


namespace LMS.Core.Repositories
{
    public interface IClassRepository:IRepository<Classes>
    {
        //here we have all the custom operations
        Task<IEnumerable<Classes>> GetClassesByName(string name);
    }
}
