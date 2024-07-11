namespace ProfessorAssignmentApi.Infrastructure.Repositories;
public interface IProfessorRepository
{
    public Task<Professor?> Get(string email);
}