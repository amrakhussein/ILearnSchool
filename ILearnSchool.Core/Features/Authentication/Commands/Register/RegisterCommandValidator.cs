using FluentValidation;

using ILearnSchool.Core.Helper;

namespace ILearnSchool.Core.Features.Authentication.Commands.Register;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty()
                                 .MinimumLength(2)
                                 .MaximumLength(100);

        RuleFor(x => x.LastName).NotEmpty()
                                .MinimumLength(2)
                                .MaximumLength(100);

        RuleFor(x => x.Email).NotEmpty()
                             .EmailAddress();
        // for dev
        RuleFor(x => x.Password).NotEmpty()
                                .MinimumLength(1);

        RuleFor(x => x.Roles)
                             .NotEmpty()
                             .Must(roles => roles.All(role => UserRoleChecker.Contains(role)))
                             .WithMessage("Invalid role specified.");
    }
}
