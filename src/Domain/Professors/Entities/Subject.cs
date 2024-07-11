namespace ProfessorAssignmentApi.Domain.Professors.Entities;

/// <summary>
/// Represents a Subject entity.
/// </summary>
public class Subject
{
    /// <summary>
    /// Gets or sets the identifier of the subject.
    /// </summary>
    public string Id { get; set; } = default!;

    /// <summary>
    /// Gets or sets the Arabic name of the subject.
    /// </summary>
    public string NameAr { get; set; } = default!;

    /// <summary>
    /// Gets or sets the French name of the subject.
    /// </summary>
    public string NameFr { get; set; } = default!;

	/// <summary>
	/// Gets or sets the list of levels associated with the subject.
	/// </summary>
	public List<Level> Levels { get; set; } = [];
}
