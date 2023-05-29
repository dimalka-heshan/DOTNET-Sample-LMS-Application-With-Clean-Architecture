using LMS.Application.Responses.ClassesResponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Queries.ClassesQueries
{
    public class GetClassesByNameQuery: IRequest<IEnumerable<ClassResponse>>
    {
        public string Name { get; set; }

        public GetClassesByNameQuery(string name)
        {
            Name = name;
        }
    }
}
