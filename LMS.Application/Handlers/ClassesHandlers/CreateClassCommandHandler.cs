using LMS.Application.Commands;
using LMS.Application.Commands.ClassesCommands;
using LMS.Application.Mappers.ClassMappers;
using LMS.Application.Responses.ClassesResponses;
using LMS.Core.Entities;
using LMS.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Handlers.ClassesHandlers
{
    public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, ClassResponse>
    {
        private readonly IClassRepository _classRepository;

        public CreateClassCommandHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public async Task<ClassResponse> Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            var classEntity = ClassMapper.Mapper.Map<Classes>(request);
            if (classEntity is null)
            {
                throw new ApplicationException("There is an issue with mapping...");

            }

            var newClass = await _classRepository.AddAsync(classEntity);
            var classResponse = ClassMapper.Mapper.Map<ClassResponse>(newClass);

            return classResponse;
        }
    }
}
