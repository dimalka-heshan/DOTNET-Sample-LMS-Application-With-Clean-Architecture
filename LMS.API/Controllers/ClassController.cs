using LMS.API.Controller;
using LMS.Application.Commands.ClassesCommands;
using LMS.Application.Queries.ClassesQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    public class ClassController:APIController
    {
        private readonly IMediator _mediator;

        public ClassController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ClassResponse>> GetClassById(Guid CalssId)
        {
            var query = new GetClassQuery(CalssId);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Create( CreateClassCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(UpdateClassCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(Guid UserId,Guid id)
        {
            var command = new DeleteClassCommand(UserId, id); // Assuming you have the UserId available
            await _mediator.Send(command);

            return Ok();
        }


    }
}
