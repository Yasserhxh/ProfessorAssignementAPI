namespace ProfessorAssignmentApi.Api.Application.Common.Models;

/// <summary>
/// Represents a Professor DTO.
/// </summary>
/// <param name="Id"></param>
public record ProfessorDTO
{
	public long Id { get; init; }
	public string LastNameArabic { get; init; } = default!;
	public string FirstNameArabic { get; init; } = default!;
	public string LastNameFrench { get; init; } = default!;
	public string FirstNameFrench { get; init; } = default!;
	public string Email { get; init; } = default!;
	public SchoolDTO School { get; init; } = default!;
	public List<SubjectDTO> Subjects { get; init; } = [];
}
