using ErrorOr;

using IlearnSchool.Core.Dtos.Authentication;

using MediatR;

namespace ILearnSchool.Core.Features.Authentication.Commands.Register;

public record RegisterCommand(string FirstName,
                              string LastName,
                              string Email,
                              string Password,
                              string[] Roles) : IRequest<ErrorOr<AuthenticatedUserResponseDto>>;
