namespace ProfessorAssignmentApi.Domain.Professors.Entities;

/// <summary>
/// Represents a School entity.
/// </summary>
public sealed class School
{
    /// <summary>
    /// Gets or sets the code of the school.
    /// </summary>
    public string SchoolCode { get; set; } = default!;

    /// <summary>
    /// Gets or sets the Arabic name of the school.
    /// </summary>
    public string NameAr { get; set; } = default!;

    /// <summary>
    /// Gets or sets the French name of the school.
    /// </summary>
    public string NameFr { get; set; } = default!;
}
