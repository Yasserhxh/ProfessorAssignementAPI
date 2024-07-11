using ProfessorAssignmentApi.Api.Application.Common.Exceptions;
namespace ProfessorAssignmentApi.Api.Application.Professors.GetProfessor;

/// <summary>
/// Handles the request to get a professor by email.
/// </summary>
public class GetProfessorHandler : IRequestHandler<GetProfessorQuery, GetProfessorResponse>
{
    private readonly IProfessorRepository _professorRepository;

	/// <summary>
	/// Initializes a new instance of the <see cref="GetProfessorHandler"/> class.
	/// </summary>
	/// <param name="professorRepository">The repository to access professor data.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="professorRepository"/> is null.</exception>
	public GetProfessorHandler(IProfessorRepository professorRepository)
    {
        ArgumentNullException.ThrowIfNull(professorRepository);

        _professorRepository=professorRepository;
    }

	/// <summary>
	/// Handles the query to get a professor by email.
	/// </summary>
	/// <param name="request">The request containing the email of the professor.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the response with the professor details.</returns>
	public async Task<GetProfessorResponse> Handle(GetProfessorQuery request, CancellationToken cancellationToken)
	{
        var professor = await _professorRepository.Get(request.Email) 
			?? throw new NotFoundException($"The professor with the provided email: {request.Email}, does not exist");
		var res = professor.Adapt<GetProfessorResponse>();
		return res;
	
    }
}
