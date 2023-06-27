using LMS.Application.Data;
using LMS.Core.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LMS.Application.Queries.ClassesQueries
{
    public class GetClassesByIdHandler : IRequestHandler<GetClassQuery, ClassResponse>
    {
        private readonly IClassRepository _classRepository;
        private readonly IApplicationDbContext _applicationDbContext;

        public GetClassesByIdHandler(IClassRepository classRepository , IApplicationDbContext applicationDbContext)
        {
            _classRepository = classRepository;
            _applicationDbContext = applicationDbContext;
        }
        public async Task<ClassResponse?> Handle(GetClassQuery request, CancellationToken cancellationToken)
        {
            var ClassRes = await _applicationDbContext
                .Classes
                .Where(x => x.ClassId == request.ClassId)
                .Select(x => new ClassResponse(
                    x.ClassId,
                    x.Name,
                    x.TeacherId,
                    x.Created,
                    x.CreatedBy,
                    x.Modified.Value,
                    x.ModifiedBy.Value))
                .FirstOrDefaultAsync(cancellationToken);

            return ClassRes;
        }
    }


}
