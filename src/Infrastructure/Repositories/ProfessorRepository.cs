using ProfessorAssignmentApi.Domain.Professors.Entities;

namespace ProfessorAssignmentApi.Infrastructure.Repositories;

internal sealed class ProfessorRepository : IProfessorRepository
{
    public Professor Get(string email)
    {
        return new Professor();
    }
}
