using AutoMapper;
using LMS.Application.Commands;
using LMS.Application.Commands.ClassesCommands;
using LMS.Application.Responses.ClassesResponses;
using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Mappers.ClassMappers
{
    public class ClassMappingProfile : Profile
    {
        public ClassMappingProfile()
        {
            CreateMap<Classes, ClassResponse>().ReverseMap();
            CreateMap<Classes, CreateClassCommand>().ReverseMap();
        }
    }
}
