using ProfessorAssignmentApi.Api.Application.Professors.GetProfessor;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProfessorAssignmentApi.Api.Controllers
{
	/// <summary>
	/// Controller to manage professor-related operations.
	/// </summary>
	[Route("professors")]
	public class ProfessorController : ApiControllerBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProfessorController"/> class.
		/// </summary>
		/// <param name="mediator">The mediator to handle requests.</param>
		public ProfessorController(ISender mediator) : base(mediator)
		{
		}

		/// <summary>
		/// Gets the details of a professor by email.
		/// </summary>
		/// <param name="query">The query containing the email of the professor.</param>
		/// <returns>An <see cref="IActionResult"/> containing the details of the professor.</returns>
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
}
