using System.Security.Cryptography;

using ILearnSchool.Core.Interfaces.Infrastructure.Authentication;
using ILearnSchool.Core.Models;

namespace ILearnSchool.Infrastructure.Authentication;

public class RefreshTokenGenerator : IRefreshTokenGenerator
{
    public RefreshToken GenerateRefreshToken(ApplicationUser user)
    {
        var randomBytes = new byte[64];
        using var cryptoServiceProvider = new RNGCryptoServiceProvider();

        // Generate a secure random bytes storing them into the randomBytes array
        cryptoServiceProvider.GetBytes(randomBytes);
        var generatedRefreshToken = Convert.ToBase64String(randomBytes);

        return new RefreshToken
        {
            Token = generatedRefreshToken,
            ExpiryDate = DateTime.UtcNow.AddMinutes(1), // one min for testing purposes
            UserId = user.Id,
        };
    }
}
