namespace ProfessorAssignmentApi.Api.Application.Common.Models;

/// <summary>
/// Represents a School DTO.
/// </summary>
public record SchoolDTO
{
	public string Code { get; init; } = default!;
	public string NameAr { get; init; } = default!;
	public string NameFr { get; init; } = default!;
}
