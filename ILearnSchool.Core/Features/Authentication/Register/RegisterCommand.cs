using ErrorOr;

using ILearnSchool.Core.Features.Authentication.Common;

using MediatR;

namespace ILearnSchool.Core.Features.Authentication.Register;

public record RegisterCommand(string FirstName,
                              string LastName,
                              string Email,
                              string Password,
                              string[] Roles) : IRequest<ErrorOr<AuthenticationResult>>;
