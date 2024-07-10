using ProfessorAssignmentApi.Domain.Professors.Entities;

namespace ProfessorAssignmentApi.Infrastructure.Repositories;

public interface IProfessorRepository
{
    public Professor Get(string email);
}