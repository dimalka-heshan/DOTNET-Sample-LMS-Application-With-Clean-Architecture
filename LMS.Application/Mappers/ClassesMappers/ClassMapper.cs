using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Mappers.ClassMappers
{
    public class ClassMapper
    {
        private static readonly Lazy<IMapper> lazy = new(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<ClassMappingProfile>();

            });

            var mapper = config.CreateMapper();
            
            return mapper;

        });

        public static IMapper Mapper => lazy.Value;
    }
}
