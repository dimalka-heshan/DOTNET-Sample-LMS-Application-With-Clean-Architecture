using MediatR;


namespace LMS.Application.Commands.ClassesCommands
{
    public record UpdateClassCommand(Guid ClassId, Guid user, string Name, Guid TeacherId):IRequest;
    
    
}
