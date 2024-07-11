namespace ProfessorAssignmentApi.Api.Application.Common.Models;

/// <summary>
/// Represents a Class Entity DTO.
/// </summary>
public record ClassEntityDTO
{
	public string Id { get; init; } = default!;
	public string Name { get; init; } = default!;
	public long YearId { get; init; }
	public int NumberOfStudents { get; init; }
}
