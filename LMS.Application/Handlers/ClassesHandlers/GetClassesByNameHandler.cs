using LMS.Application.Mappers.ClassMappers;
using LMS.Application.Queries.ClassesQueries;
using LMS.Application.Responses.ClassesResponses;
using LMS.Core.Repositories;
using MediatR;

namespace LMS.Application.Handlers.ClassesHandlers
{
    public class GetClassesByNameHandler: IRequestHandler<GetClassesByNameQuery,IEnumerable<ClassResponse> >
    {
        private readonly IClassRepository _classRepository;

        public GetClassesByNameHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task<IEnumerable<ClassResponse>> Handle(GetClassesByNameQuery request, CancellationToken cancellationToken)
        {
            var classList = await _classRepository.GetClassesByName(request.Name);
            var classResponseList = ClassMapper.Mapper.Map<ClassResponse>(classList);
            return (IEnumerable<ClassResponse>)classResponseList;
        }
    }

    
}
