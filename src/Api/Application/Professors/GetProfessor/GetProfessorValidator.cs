namespace ProfessorAssignmentApi.Api.Application.Professors.GetProfessor;

public class GetProfessorValidator : AbstractValidator<GetProfessorQuery>
{
    public GetProfessorValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email address is required.")
            .EmailAddress().WithMessage("Invalid email address format.");
    }
}
