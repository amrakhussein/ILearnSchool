using ErrorOr;

using ILearnSchool.Core.Features.Authentication.Common;

using MediatR;

namespace ILearnSchool.Core.Features.Authentication.Login;

public record LoginQuery(string Email,
                         string Password) : IRequest<ErrorOr<AuthenticationResult>>;