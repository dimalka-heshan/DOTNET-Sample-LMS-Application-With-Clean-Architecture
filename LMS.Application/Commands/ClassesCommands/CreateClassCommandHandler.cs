using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Core.Repositories.Base;
using MediatR;


namespace LMS.Application.Commands.ClassesCommands
{
    public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand>
    {
        private readonly IClassRepository _classRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateClassCommandHandler(IClassRepository classRepository, IUnitOfWork unitOfWork)
        {
            _classRepository = classRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            var classes = new Classes(Guid.NewGuid(), request.Name, request.TeacherId);

            _classRepository.Add(classes);

            await _unitOfWork.SaveChangesAsync(request.user, cancellationToken);
        }

        
    }
}
