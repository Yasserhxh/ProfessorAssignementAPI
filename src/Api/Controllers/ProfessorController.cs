using MediatR;
using ProfessorAssignmentApi.Api.Application.Professors.GetProfessor;

namespace ProfessorAssignmentApi.Api.Controllers;

[Route("professors")]
public class ProfessorController : ApiControllerBase
{
    public ProfessorController(ISender mediator) : base(mediator)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetProfessor([FromQuery] GetProfessorQuery query)
    {
        // Send the request to the mediator to handle
        var response = await _mediator.Send(query);

        // Return the response as Ok result
        return Ok(response);
    }
}
