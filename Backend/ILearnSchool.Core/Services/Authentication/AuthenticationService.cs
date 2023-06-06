using ILearnSchool.Core.Interfaces.Authentication;

namespace ILearnSchool.Core.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        Guid userId = Guid.NewGuid();

        // check if user exist

        // create user by generating unique id

        // create JWT token
        var token = _jwtTokenGenerator.GenerateJwtToken(userId, firstName, lastName);
        return new AuthenticationResult(userId,
                                        firstName,
                                        lastName,
                                        email,
                                        token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(),
                                        "first",
                                        "last",
                                        email,
                                        "token");
    }
}
