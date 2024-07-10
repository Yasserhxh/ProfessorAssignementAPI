namespace ProfessorAssignmentApi.Domain.Professors.Entities;

/// <summary>
/// Represents a classroom entity.
/// </summary>
public class ClassEntity
{
    /// <summary>
    /// Gets or sets the identifier of the classroom.
    /// </summary>
    public string Id { get; set; } = default!;

    /// <summary>
    /// Gets or sets the name of the classroom.
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    /// Gets or sets the year identifier associated with the classroom.
    /// </summary>
    public long YearId { get; set; }

    /// <summary>
    /// Gets or sets the number of students in the classroom.
    /// </summary>
    public int NumberOfStudents { get; set; }
}
