namespace ProfessorAssignmentApi.Api.Application.Common.Models;

/// <summary>
/// Represents a Level DTO.
/// </summary>
public record LevelDTO
{
	public string Id { get; init; } = default!;
	public string NameAr { get; init; } = default!;
	public string NameFr { get; init; } = default!;
	public List<ClassEntityDTO> Classes { get; init; } = [];
}
