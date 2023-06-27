using MediatR;


namespace LMS.Application.Commands.ClassesCommands
{
    public record CreateClassCommand(Guid user, string Name, Guid TeacherId) : IRequest;
   
}
