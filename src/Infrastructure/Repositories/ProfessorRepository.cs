namespace ProfessorAssignmentApi.Infrastructure.Repositories;
/// <summary>
/// Repository for managing professor data.
/// </summary>
public sealed class ProfessorRepository : IProfessorRepository
{
	private readonly IDbConnection _db;

	/// <summary>
	/// Initializes a new instance of the <see cref="ProfessorRepository"/> class.
	/// </summary>
	/// <param name="db">The database connection.</param>
	public ProfessorRepository(IDbConnection db)
	{
		_db = db;
	}

	/// <summary>
	/// Retrieves a professor's details, including their school and subjects, based on the given email.
	/// </summary>
	/// <param name="email">The email of the professor.</param>
	/// <returns>A <see cref="Professor"/> object containing the professor's details.</returns>
	public async Task<Professor?> Get(string email)
	{
		using var multi = await _db.QueryMultipleAsync("GetPersonnelDetails", new { Email = email }, commandType: CommandType.StoredProcedure);
		var professor = multi.Read<Professor>().FirstOrDefault();

		if (professor == null) return null;


		var schools = multi.Read<School>().ToList();

		if(schools.Count == 0) return null;

		var subjectData = multi.Read<(string SubjectId, string SubjectNameAr, string SubjectNameFr, string LevelId, string LevelNameAr, string LevelNameFr, Guid ClassId, string ClassName, int YearId, int NumberOfStudents)>().ToList();

		var subjects = subjectData
			.GroupBy(sd => new { sd.SubjectId, sd.SubjectNameAr, sd.SubjectNameFr })
			.Select(g => new Subject
			{
				Id = g.Key.SubjectId,
				NameAr = g.Key.SubjectNameAr,
				NameFr = g.Key.SubjectNameFr,
				Levels = g.GroupBy(sd => new { sd.LevelId, sd.LevelNameAr, sd.LevelNameFr })
						  .Select(lg => new Level
						  {
							  Id = lg.Key.LevelId,
							  NameAr = lg.Key.LevelNameAr,
							  NameFr = lg.Key.LevelNameFr,
							  Classes = lg.GroupBy(x => new { x.ClassId, x.ClassName, x.YearId, x.NumberOfStudents })
							  .Select(c => new ClassEntity
							  {
								  Id = c.Key.ClassId,
								  Name = c.Key.ClassName,
								  YearId = c.Key.YearId,
								  NumberOfStudents = c.Key.NumberOfStudents
							  }).ToList()
						  }).ToList()
			}).ToList();
		professor.School = schools.First();
		professor.Subjects = subjects;
		return professor;
	}
}
