using MediatR;
using ProfessorAssignmentApi.Infrastructure.Repositories;

namespace ProfessorAssignmentApi.Api.Application.Professors.GetProfessor;

public class GetProfessorHandler : IRequestHandler<GetProfessorQuery, GetProfessorResponse>
{
    private readonly IProfessorRepository _professorRepository;

    public GetProfessorHandler(IProfessorRepository professorRepository)
    {
        ArgumentNullException.ThrowIfNull(professorRepository);

        _professorRepository=professorRepository;
    }

    public async Task<GetProfessorResponse> Handle(GetProfessorQuery request, CancellationToken cancellationToken)
    {
        throw new Exception("testaaaaaai exception");
    }
}
