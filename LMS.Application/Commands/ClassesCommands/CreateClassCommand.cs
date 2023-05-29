using LMS.Application.Responses.ClassesResponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Commands.ClassesCommands
{
    public class CreateClassCommand : IRequest<ClassResponse>
    {
        public Guid ClassId { get; set; }
        public string Name { get; set; }
        public Guid TeacherId { get; set; }
    }
}
