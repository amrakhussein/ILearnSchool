using ILearnSchool.Core.Models;

namespace ILearnSchool.Core.Interfaces.Infrastructure.Authentication;

public interface IAccessTokenGenerator
{
    Task<string> GenerateAccessTokenAsync(ApplicationUser user);
}
