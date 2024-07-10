namespace ProfessorAssignmentApi.Domain.Professors.Entities;

/// <summary>
/// Represents a Professor entity.
/// </summary>
public class Professor
{
    /// <summary>
    /// Gets or sets the unique identifier of the professor.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the Arabic last name of the professor.
    /// </summary>
    public string LastNameArabic { get; set; } = default!;

    /// <summary>
    /// Gets or sets the Arabic first name of the professor.
    /// </summary>
    public string FirstNameArabic { get; set; } = default!;

    /// <summary>
    /// Gets or sets the French last name of the professor.
    /// </summary>
    public string LastNameFrench { get; set; } = default!;

    /// <summary>
    /// Gets or sets the French first name of the professor.
    /// </summary>
    public string FirstNameFrench { get; set; } = default!;

    /// <summary>
    /// Gets or sets the email address of the professor.
    /// </summary>
    public string Email { get; set; } = default!;

    /// <summary>
    /// Gets or sets the school associated with the professor.
    /// </summary>
    public School School { get; set; } = default!;

    /// <summary>
    /// Gets or sets the list of subjects taught by the professor.
    /// </summary>
    public List<Subject> Subjects { get; set; } = [];
}
