
using MediatR;

namespace LMS.Application.Queries.ClassesQueries
{
    public record GetClassQuery(Guid ClassId) : IRequest<ClassResponse>;

    public record ClassResponse(Guid ClassId, string Name, Guid TeacherId, DateTime Created, Guid CreatedBy, DateTime Modified, Guid ModifiedBy);
}
