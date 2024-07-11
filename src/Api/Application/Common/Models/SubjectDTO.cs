namespace ProfessorAssignmentApi.Api.Application.Common.Models;

/// <summary>
/// Represents a Subject DTO.
/// </summary>
public record SubjectDTO
{
	public string Id { get; init; } = default!;
	public string NameAr { get; init; } = default!;
	public string NameFr { get; init; } = default!;
	public List<LevelDTO> Levels { get; init; } = [];
}
