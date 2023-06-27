using LMS.Core.Entities;
using LMS.Core.Repositories;
using LMS.Core.Repositories.Base;
using MediatR;

namespace LMS.Application.Commands.ClassesCommands
{
    public class UpdateClassComandHandler : IRequestHandler<UpdateClassCommand>
    {
        private readonly IClassRepository _classRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateClassComandHandler(IClassRepository classRepository, IUnitOfWork unitOfWork)
        {
            _classRepository = classRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(UpdateClassCommand request, CancellationToken cancellationToken)
        {
            var classes =await _classRepository.GetByIdAsync(request.ClassId);


            if(classes == null)
            {
                // Handle the case when the class is not found
                throw new FileNotFoundException($"Class with ID {request.ClassId} not found.");
            }

            // Update the class properties
            classes = new Classes(request.ClassId, request.Name, request.TeacherId);

            // Persist the changes
            _classRepository.Update(classes);

            await _unitOfWork.SaveChangesAsync(request.user, cancellationToken);
        }
    }
}
