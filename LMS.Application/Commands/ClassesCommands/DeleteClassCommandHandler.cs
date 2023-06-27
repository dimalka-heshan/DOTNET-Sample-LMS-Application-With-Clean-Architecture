using LMS.Core.Repositories.Base;
using LMS.Core.Repositories;
using MediatR;
using LMS.Application.Data;

namespace LMS.Application.Commands.ClassesCommands
{
    public class DeleteClassCommandHandler : IRequestHandler<DeleteClassCommand>
    {
        private readonly IClassRepository _classRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteClassCommandHandler(IClassRepository classRepository, IUnitOfWork unitOfWork)
        {
            _classRepository = classRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(DeleteClassCommand request, CancellationToken cancellationToken)
        {
            var existingClass = await _classRepository.GetByIdAsync(request.ClassId);

            if (existingClass == null)
            {
                // Handle the case when the class does not exist
                throw new DllNotFoundException("Class not found");
            }

            _classRepository.Delete(existingClass);

            await _unitOfWork.SaveChangesAsync(request.user, cancellationToken);





        }
    }
}
