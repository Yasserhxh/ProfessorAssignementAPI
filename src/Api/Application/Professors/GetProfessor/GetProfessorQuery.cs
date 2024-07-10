using MediatR;

namespace ProfessorAssignmentApi.Api.Application.Professors.GetProfessor;

/// <summary>
/// Represents a query object used to retrieve details of a professor by their email address.
/// </summary>
public record GetProfessorQuery : IRequest<GetProfessorResponse>
{
    /// <summary>
    /// Gets or initializes the email address of the professor.
    /// </summary>
    public string Email { get; init; } = default!;
}

