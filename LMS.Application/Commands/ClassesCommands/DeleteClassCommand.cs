

using MediatR;

namespace LMS.Application.Commands.ClassesCommands
{
    public record DeleteClassCommand(Guid user,Guid ClassId):IRequest;
    
    
}
