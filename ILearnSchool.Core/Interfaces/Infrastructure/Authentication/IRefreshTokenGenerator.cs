using ILearnSchool.Core.Models;

namespace ILearnSchool.Core.Interfaces.Infrastructure.Authentication;

public interface IRefreshTokenGenerator
{
    RefreshToken GenerateRefreshToken(ApplicationUser user);
}