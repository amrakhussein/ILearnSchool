using ErrorOr;

using ILearnSchool.Core.Features.Authentication.Common;
using ILearnSchool.Core.Interfaces.Authentication;
using ILearnSchool.Core.Interfaces.Persistence;
using ILearnSchool.Core.ServiceErrors;

using MediatR;

namespace ILearnSchool.Core.Features.Authentication.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByEmailAsync(query.Email);
        if (user is null)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        // check user with correct credentials
        var hasUserValidated = await _userRepository.ValidatePasswordAsync(user, query.Password, false);

        if (!hasUserValidated) return Errors.Authentication.InvalidCredentials;

        // Generate a JWT token for the user
        var token = await _jwtTokenGenerator.GenerateJwtTokenAsync(user);

        return new AuthenticationResult(user, token);
    }
}
