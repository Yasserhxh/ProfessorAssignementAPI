namespace ProfessorAssignmentApi.Domain.Professors.Entities;

/// <summary>
/// Represents a Level entity.
/// </summary>
public class Level
{
    /// <summary>
    /// Gets or sets the identifier of the level.
    /// </summary>
    public string Id { get; set; } = default!;

    /// <summary>
    /// Gets or sets the Arabic name of the level.
    /// </summary>
    public string NameAr { get; set; } = default!;

    /// <summary>
    /// Gets or sets the French name of the level.
    /// </summary>
    public string NameFr { get; set; } = default!;

    /// <summary>
    /// Gets or sets the list of classes associated with the level.
    /// </summary>
    public List<ClassEntity> Classes { get; set; } = [];
}