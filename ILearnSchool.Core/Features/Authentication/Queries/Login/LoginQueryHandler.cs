using ErrorOr;

using IlearnSchool.Core.Dtos.Authentication;

using ILearnSchool.Core.Interfaces.Infrastructure.Authentication;
using ILearnSchool.Core.Interfaces.Persistence;
using ILearnSchool.Core.ServiceErrors;

using MediatR;

namespace ILearnSchool.Core.Features.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticatedUserResponseDto>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticatedUserResponseDto>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByEmailAsync(query.Email);
        if (user is null)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        // Check user with correct credentials
        var hasUserValidated = await _userRepository.ValidatePasswordAsync(user, query.Password, false);

        if (!hasUserValidated) return Errors.Authentication.InvalidCredentials;

        // Generate a JWT token for the user
        var token = await _jwtTokenGenerator.GenerateJwtTokenAsync(user);

        return new AuthenticatedUserResponseDto
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Token = token
        };
    }
}
