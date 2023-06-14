using ErrorOr;

using IlearnSchool.Core.Dtos.Authentication;

using MediatR;

namespace ILearnSchool.Core.Features.Authentication.Queries.Login;

public record LoginQuery(string Email,
                         string Password) : IRequest<ErrorOr<AuthenticatedUserResponseDto>>;